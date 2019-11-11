using System;
using System.IO;
namespace LaravelDeployer.Helpers
{
    public class IOHelper
    {
        private readonly string localDirectory;
        public IOHelper(string localDirectory)
        {
            this.localDirectory = Path.GetFullPath(localDirectory.Equals("") ? Environment.CurrentDirectory : localDirectory);
        }
    }
}