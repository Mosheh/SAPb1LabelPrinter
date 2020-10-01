using DevExpress.XtraReports.Serialization;
using DevExpress.XtraRichEdit.Model;
using ICSharpCode.TextEditor.Document;
using LabelPrinting.UI.Infra;
using LabelPrinting.UI.Infra.Data;
using LabelPrinting.UI.UI;
using LabelPrinting.UI.UI.Settings;
using LabelPrinting.UI.UI.SqlEditors;
using Nampula.DI;
using Nampula.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using App = Nampula.UI.Application;
using Application = System.Windows.Forms.Application;
using MenuItem = Nampula.UI.MenuItem;
namespace LabelPrinting
{
    static class Program
    {
        static App app = null;
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            try
            {

                HighlightingManager.Manager.AddSyntaxModeFileProvider(
                new SyntaxEditor());

                if (ConfigHelper.IsStandalone)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new LabelPrintingForm());
                }
                else
                {
                    app = Nampula.UI.Application.GetInstance();

                    app.OnStartCreateMenu += App_OnStartCreateMenu;
                    app.OnStartConnection += App_OnStartConnection;
                    app.OnShutDown += App_OnShutDown;

                    if (app.StartApplication("LP", Nampula.UI.eAppType.SAPForms))
                    {
                        var mainForm = app.MainForm();
                        Application.Run(mainForm);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private static void App_OnShutDown(object sender, Nampula.UI.ApplicationEventArgs e)
        {
            Application.Exit();
        }

        private static void App_OnStartConnection(object sender, Nampula.UI.ApplicationEventArgs e)
        {
            try
            {
                var param = App.GetInstance().GetParam();
                Nampula.DI.Connection.Instance.ConnectionParameter = param;
                var conn = Connection.Instance.SqlDialect.GetDbConnection();
                conn.ConnectionString = param.ToString();
                SboConnection.Init(Nampula.UI.ApplicationSAP.GetInstance().CompanySbo, conn);
                var sboConn = new SboConnection();
                sboConn.CreateUserTables();
                new AppSession(sboConn);

            }
            catch (COMException ex)
            {
                MessageBox.Show("Provel problema de DI API ou SAP bloqueou criação das tabelas do Add-on. Tente reiniciar o client");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private static void App_OnStartCreateMenu(object sender, Nampula.UI.ApplicationEventArgs e)
        {
            var module = Nampula.UI.Application.GetInstance().GetMenu(MenuID.cBoUIModulesMenu);
            var menuAddon = new Nampula.UI.MenuItem(module, BoMenuType.mt_POPUP, "Impressão de etiquetas", UI.Properties.Resources.label);

            var menuLabelPrinting = new MenuItem(menuAddon, BoMenuType.mt_STRING, "Impressão");

            var menuConfig = new MenuItem(menuAddon, BoMenuType.mt_POPUP, "Configurações");
            var menuGeneralConfig = new MenuItem(menuConfig, BoMenuType.mt_STRING, "Configurações Gerais");
            menuGeneralConfig.OnAfterClick += MenuGeneralConfig_OnAfterClick;
        }

        private static void MenuGeneralConfig_OnAfterClick(object sender, MenuEventArgs e)
        {
            var form = new LabelModelForm();
            form.Show();
        }

        public static void ShowMessageError(Exception ex)
        {
            if (ConfigHelper.IsStandalone)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            else
            {
                app.MessageBox(ex.Message);
            }
        }

        public static void ShowSuccessfullMessage()
        {
            if (ConfigHelper.IsStandalone)
            {
                System.Windows.Forms.MessageBox.Show("Operação realizada com sucesso!");
            }
            else
            {
                app.MessageBox("Operação realizada com sucesso!");
            }
        }
    }
}
