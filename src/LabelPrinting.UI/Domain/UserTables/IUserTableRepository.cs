using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabelPrinting.UI.Domain.UserTables
{
    public interface IUserTableRepository
    {
        void Add(UserTable userTable);
    }
}
