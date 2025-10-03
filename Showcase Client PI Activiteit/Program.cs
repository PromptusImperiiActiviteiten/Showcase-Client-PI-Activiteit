namespace Showcase_Client_PI_Activiteit
{
    internal static class Program
    {
        public static Client client { get; private set; }
        public static LoginScreenForm loginScreen { get; private set; }
        public static ChatroomForm chatroom { get; private set; }

        [STAThread]
        static void Main()
        {
            client = new Client();

            ApplicationConfiguration.Initialize();

            loginScreen = new LoginScreenForm();
            chatroom = new ChatroomForm();

            Application.Run(loginScreen);
        }
    }
}