namespace Showcase_Client_PI_Activiteit
{
    internal static class Program
    {
        public static Client client { get; set; }
        [STAThread]
        static void Main()
        {
            client = new Client();

            ApplicationConfiguration.Initialize();
            Application.Run(new LoginScreenForm());
        }
    }
}