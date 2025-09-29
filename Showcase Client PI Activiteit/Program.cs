namespace Showcase_Client_PI_Activiteit
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SimpleClient client = new SimpleClient();
            client.ConnectToServer("127.0.0.1", 5000); // Connect to localhost

            Console.WriteLine("Type a message to send:");
            string message = Console.ReadLine();
            client.SendMessage(message);
            
      
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}