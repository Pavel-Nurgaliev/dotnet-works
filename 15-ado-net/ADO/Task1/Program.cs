using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsersAndRewardsBL;
using UsersAndRewardsDAL;
using System.Data.Common;
using System.Data.SqlClient;
using System.Configuration;

namespace Task1
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            SelectDAL();
        }

        private static void SelectDAL()
        {
            var key = ConfigurationManager.AppSettings.Get("FirstSettingDAO");
            if (MessageBox.Show("Do you've want use local database?", "SelectDataSource", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes
                && key == "Success")
            {
                MessageBox.Show("You use local database", "LocalDataBase", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Run(
            new MainForm(null, null, ConnectDataBase()));
            }
            else
            {
                MessageBox.Show("You use collection data", "CollectionData", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Run(
                new MainForm(new UsersDataManager(InitCollection()),
                new RewardsDataManager(InitCollection()), ""));
            }
        }

        private static StoreData InitCollection()
        {
            return new StoreData();
        }

        private static string ConnectDataBase()
        {
            //var connectionStringBuilder = new SqlConnectionStringBuilder();
            //connectionStringBuilder.DataSource = "DESKTOP-8O09UO5\\SSQLSERVER_R";
            //connectionStringBuilder.InitialCatalog = "UsersAndRewardsDB";
            //connectionStringBuilder.IntegratedSecurity = true;

            string connectionStringBuilder =
                ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            return connectionStringBuilder.ToString();
        }
    }
}
