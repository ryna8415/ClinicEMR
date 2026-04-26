using ClinicEMR.Forms;
using ClinicEMR.Services;

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
            SchemaService.EnsureDatabaseObjects();

            Application.Run(new LoginForm());
        }
    }
}
