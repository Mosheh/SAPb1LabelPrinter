using LabelPrinting.UI.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabelPrinting.UI.Infra
{
    public sealed class AppSession 
    {
        public AppSession(ISboConnection sboConnection)
        {
            SboConnection = sboConnection;
        }


        private static ISboConnection sboConnection;

        public static ISboConnection SboConnection
        {
            get { return  sboConnection; }
            set { sboConnection = value; }
        }


    }
}
