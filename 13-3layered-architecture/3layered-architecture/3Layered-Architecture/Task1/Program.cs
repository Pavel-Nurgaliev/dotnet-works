using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsersAndRewardsBL;
using UsersAndRewardsDAL;

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

            var data = new StoreData();

            Application.Run(new MainForm(new UsersDataManager(data), new RewardsDataManager(data)));
        }
    }
}
