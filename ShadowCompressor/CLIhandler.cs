using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ShadowCompressor
{
    public class CLIhandler
    {
        private Process p;
        private ProcessStartInfo startInfo;
        public CLIhandler(String dir)
        {
            this.p = new Process();
            this.startInfo = new ProcessStartInfo();
            startInfo.FileName = "cmd.exe";
            startInfo.RedirectStandardInput = true;
            startInfo.RedirectStandardOutput = false;
            startInfo.UseShellExecute = false;
            startInfo.WorkingDirectory = dir; //Directory where HandBrakeCLI.exe is
            p.StartInfo = startInfo;
            p.Start();
        }

        public void exec(String command)
        {
            p.StandardInput.WriteLine(command);
            p.StandardInput.Flush();
        }        
    }
}
