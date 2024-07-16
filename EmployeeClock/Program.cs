using EmployeeClock.DAL;
using Microsoft.Extensions.Configuration;


namespace EmployeeClock
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>]
        public static IConfiguration Configuration { get; private set; }

        [STAThread]

        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            ApplicationConfiguration.Initialize();
            DBContext DB = new DBContext();
            FormHandler.CloseAllForms();
            FormHandler.ShowForms<string>("LoginForm", DB);
            Application.Run();
        }
    }
}