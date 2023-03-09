using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp.Forms;
using WinFormsApp.Controllers;
using WinFormsApp.DB;


namespace WinFormsApp
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

            ApplicationContext ac = new();
            DataBase db = new();
            UserController uc = new(db);
            OperationController oc = new(db);

            var loginForm = new LoginForm(ac, uc);
            var mainForm = new MainForm(ac, uc, oc);
            loginForm.Registration += () =>
            {
                new RegistrationForm(uc).Show();
            };
            loginForm.SuccessAuth += () =>
            {
                mainForm.Show();
            };
            loginForm.Show();
        }
    }
}
