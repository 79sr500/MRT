using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonitorReportsAndTools
/*
 *  General utility for monitoring purposes.
 *  
 * 2015-10-03 - v1.0.0 - Created - kdg
 *  
 * 
 */ 
{
    class Program
    {
        static void Main(string[] args)
        {
            int argLength = args.Length;
            if (argLength == 0)
            {
                Usage();
            }
            else
            {
                for (int i = 0; i < args.Length; i++)
                {
                    String CaseSwitch = args[i];
                    switch (CaseSwitch)
                    {
                        case "-clearapplicationlog":
                            ToolLibrary.LogTools.ClearLog("Application");
                            break;
                        case "-writeeventlog":
                            ToolLibrary.LogTools.MakeLogEntry();
                            break;
                        case "-clearsystemlog":
                            ToolLibrary.LogTools.ClearLog("System");
                            break;
                        case "-writesystemlog":
                            ToolLibrary.LogTools.MakeLogEntry();
                            break;
                        case "-os":
                            ReportLibrary.Reporter.ReportOSVersion();
                            break;
                        case "-osbit":
                            ReportLibrary.Reporter.ReportOSBitVersion();
                            break;
                        case "-user":
                            Console.WriteLine(Environment.UserName);
                            break;
                        case "-hostname":
                            Console.WriteLine(Environment.MachineName);
                            break;
                        case "-pwd":
                            string path = Directory.GetCurrentDirectory();
                            Console.WriteLine(path);
                            break;
                            
                        default:
                            Usage();
                            break;

                    }

                }
            }

        }

        static void Usage()
        {
            Console.WriteLine("MontorReportTool Usage:");
            Console.WriteLine("-clearapplicationlog    Clear the application log.");
            Console.WriteLine("-writeeventlog          Write a test entry to the application event log.");
            Console.WriteLine("-clearsystemlog         Clear the system log.");            
            Console.WriteLine("-os                     Show OS version.");
            Console.WriteLine("-osbit                  Show OS data type size.");
            Console.WriteLine("-user                   Show username of current process.");
            Console.WriteLine("-hostname               Show hostname.");
            Console.WriteLine("-pwd                    Print working directory.");

        }
    }
}
