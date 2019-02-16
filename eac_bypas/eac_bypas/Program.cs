using System;
using System.Linq;

namespace eac_bypass
{
    class Program
    {
        static void Main()
        {
            var process = new System.Diagnostics.Process();

            process.StartInfo.Arguments = string.Join(" ", Environment.GetCommandLineArgs().Skip(1));
            process.StartInfo.FileName = "r5apex.exe";

            process.Start();
        }
    }
}