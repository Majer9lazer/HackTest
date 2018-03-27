using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using  Microsoft.Office.Interop.Excel;
namespace HackingTests
{
    class Program
    {
        static void Main(string[] args)
        {
            //Process myTestProcess = Process.GetProcesses().FirstOrDefault(w => w.ProcessName.Contains("MyTestStudent"));
            //AppDomain dom = AppDomain.CurrentDomain;
            
            //foreach (Assembly assembly in dom.GetAssemblies())
            //{
            //    Console.WriteLine(assembly.CodeBase);
            //}

            //ProcessStartInfo processsrInfo = new ProcessStartInfo("MyTestEditor.exe");
            //Process s= Process.Start(processsrInfo);
            //processsrInfo.Arguments = "SomeTest.mtx";
            //Console.WriteLine(s.Start());
           
            
            Application excelApp = new Application();
            Workbook wpWorkbook = excelApp.Workbooks._Open(@"C:\Users\user\Desktop\123.xlsx");
            Worksheet worksheet = wpWorkbook.Worksheets[1];
            Console.ReadLine();
        }
    }
}
