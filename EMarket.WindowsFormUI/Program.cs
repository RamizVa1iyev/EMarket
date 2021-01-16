using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using EMarket.Business.Concrete;
using EMarket.Business.DependencyResolvers.Ninject;
using EMarket.DataAccess.Concrete.EntityFramework;

namespace EMarket.WindowsFormUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu(new BusinessModule()));
        }
    }
}
