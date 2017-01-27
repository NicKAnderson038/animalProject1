using Sabio.Data.Providers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Sabio.Data
{
    public sealed class DataProvider
    {
        private DataProvider() { }

        public static IDao Instance
        {
            get
            {
                return SqlDao.Instance;
            }
        }

        public static void ExecuteCmd(object getConnection, string v, object inputParamMapper, Func<IDataReader, short, object> map)
        {
            throw new NotImplementedException();
        }
    }
}
