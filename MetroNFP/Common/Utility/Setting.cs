using System;
namespace Common.Utility
{
    public class Setting
    {
        public static DataBaseType DBType
        {
            get
            {
                return MetroNFP.Properties.Settings.Default.DBType == DataBaseType.SqlServer.ToString() ? DataBaseType.SqlServer : DataBaseType.Oracle;
            }
            set
            {
                //dBType = value;
            }
        }
        public static string ConnectionString
        {
            get
            {
                return DBType == DataBaseType.SqlServer ? MetroNFP.Properties.Settings.Default.ConnectionStringSqlServer : MetroNFP.Properties.Settings.Default.ConnectionStringOracle;
            }
            set
            {
                //dBType = value;
            }
        }
    }

}
