using ClinicEMR.Forms;

namespace ClinicEMR
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            AppConfig.Init();

            Application.Run(new LoginForm());
        }
    }
}