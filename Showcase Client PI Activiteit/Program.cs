namespace Showcase_Client_PI_Activiteit
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        public static SimpleClient client { get; set; }
        [STAThread]
        static void Main()
        {
            client = new SimpleClient();

            ApplicationConfiguration.Initialize();
            Application.Run(new LoginScreenForm());
        }
    }
}