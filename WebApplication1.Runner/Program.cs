
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.IISExpressBootStrapper
{
    class Program
    {

        [System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true)]
        private static extern int GetShortPathName(String pathName, StringBuilder shortName, int cbShortName);

        static void Main(string[] args)
        {
            Console.WriteLine("Press ENTER to start WebApplication1");
            Console.ReadLine();
            var path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            var newHost = new Centaur.IISExpressHost(path, 8089);
            newHost.Start();
            System.Threading.Thread.Sleep(5000);
                System.Diagnostics.Process.Start("http://localhost:8089");
                Console.WriteLine("Press ENTER to close WebApplication1"); 
                Console.ReadLine();
                newHost.Stop();

        }
    }
}
