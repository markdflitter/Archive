using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace VooDooServiceHost
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            switch (args.Length)
            {
                case 0:
                    // default case - run as a service
                    runAsService();
                    break;
                case 1:
                    if (args[0] == "-D")
                        runAsConsoleApp();
                    else
                        printUsage();
                    break;
                default:
                    printUsage();
                    break;
            }
        }


        // private helpers
        static void runAsService()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[] 
            { 
                new VooDooHostService() 
            };
            ServiceBase.Run(ServicesToRun);
        }


        static void runAsConsoleApp()
        {
            var h = new VooDooHostService();
            h.StartVooDooHostService();

            System.Console.WriteLine("Press any key to exit...");
            System.Console.ReadKey();
            h.StopVooDooHostService();
        }


        static void printUsage()
        {
            System.Console.WriteLine("usage: VooDooServiceHost [-D]");
            System.Console.WriteLine("\t-D\t run in console mode for debugging");
        }
    }
}



// to do
// use MEF to find the service plugin
// start up te WCF service
// add logging
// properly read the version
// implement the WCF service to return the version
// simple front end app to get the version