namespace LaravelDeployer.Helpers
{
    public class FTPHelper
    {
        private readonly string host;
        private readonly int port;
        private readonly string username;
        private readonly string password;
        public FTPHelper(string host, int port, string username, string password)
        {
            this.host = host;
            this.port = port;
            this.username = username;
            this.password = password;
        }
    }
}