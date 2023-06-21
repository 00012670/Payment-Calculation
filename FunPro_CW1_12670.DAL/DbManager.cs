using System.Data.SqlServerCe;

namespace FunPro_CW1_12670.DAL
{
    public class DbManager
    {
        protected SqlCeConnection Connection
        {
            get
            {
                return new SqlCeConnection(Dal.Properties.Settings.Default.ConnectionString);
            }
        }
    }
}
