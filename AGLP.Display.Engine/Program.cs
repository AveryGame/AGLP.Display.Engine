using System;
using System.Linq;
using Microsoft.Win32;

namespace AGLP.Display.Engine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arg1 = args[0].Split('-');
            string[] arg2 = args[1].Split('-');
            string[] arg3 = args[2].Split('-');
            //string[] arg4 = args[3].Split('-');
            Console.WriteLine(arg2[1]);
            Console.WriteLine(Environment.NewLine);
            //Console.WriteLine(arg2[1].Split('=')[1]);
            Console.WriteLine(args[0] + Environment.NewLine);
            Console.WriteLine(args[1] + Environment.NewLine);
            Console.WriteLine(args[2] + Environment.NewLine);
            Console.WriteLine(arg3[1] + Environment.NewLine);
            string inpath = "null";
            //EngineParameters.InImagePath=c:/balls EngineParameters.VerboseLog EngineFunction.FTS 
            if (args[0].Contains("EngineParameters.InImagePath="))
            {
                string infilepath = arg1[1].Split('=').Last();  //args[0].Substring(args[0].IndexOf("=") + 1);
                inpath = infilepath;
            }
            //string outpath = arg2[1].Split('=')[1];
            HostingService.Host(inpath, "AveryGameLauncher2.TemporaryData.ImageEmbeddingResource.png");
            if (arg3[1].Contains("EngineParameters.VerboseLog"))
            {
                //Console.WriteLine(inpath + Environment.NewLine + outpath + Environment.NewLine + "Verbose logging enabled (Development Environment)");
                Console.ReadLine();
            }
            if (arg3[1].Contains("EngineFunction.FTS"))
            {
                Registry
                    .ClassesRoot
                    .CreateSubKey(".aglv")
                    .SetValue("", "AveryGame Launcher media", RegistryValueKind.String);
            }
            else if (args == null)
            {
                Console.WriteLine("Test");
                Console.ReadLine();
            }
                
        }
    }
}
