using System;
using System.Linq;

namespace eac_bypas
{
    class Program
    {
        static void Main()
        {
            var process = new System.Diagnostics.Process
            {
                StartInfo =
                {
                    Arguments = string.Join(" ", Environment.GetCommandLineArgs().Skip(1)),
                    FileName = "r5apex.exe"
                }
            };


            process.Start();
        }
    }
}