using System;
using System.IO;
using CommandLine;
using LaravelDeployer.Helpers;

namespace LaravelDeployer
{
    [Verb("deploy")]
    public class DeployOptions
    {
        [Option('H', "host", Required = true, HelpText = "FTP host to connect to.")]
        public string Hostname { get; set; }
        [Option('P', "port", Required = false, HelpText = "FTP port to use.", Default = 22)]
        public int Port { get; set; }
        [Option('u', "username", Required = true, HelpText = "FTP username to use.")]
        public string Username { get; set; }
        [Option('p', "password", Required = true, HelpText = "FTP password to use.")]
        public string Password { get; set; }
        [Option('d', "directory", Required = false, HelpText = "Local directory to deploy files from.", Default = "")]
        public string Directory { get; set; }
        [Option('n', "only-newer", Required = false, HelpText = "Specifies whether or not to only copy newer files.", Default = true)]
        public bool OnlyNewer { get; set; }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<DeployOptions>(args).WithParsed<DeployOptions>(Deploy);
        }

        static void Deploy(DeployOptions options)
        {
            // Create FTP helper class
            FTPHelper ftpHelper = new FTPHelper(options.Hostname, options.Port, options.Username, options.Password);

            // Create IO helper class
            IOHelper ioHelper = new IOHelper(options.Directory);


        }
    }
}
