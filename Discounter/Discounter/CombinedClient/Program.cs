namespace CombinedClient
{
    internal static class Program
    {
        /// <summary>
        /// Sets Unauthorized as default application mode
        /// </summary>
        internal static AppMode ApplicationMode = AppMode.Unauthorized;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Main());
        }
    }
}