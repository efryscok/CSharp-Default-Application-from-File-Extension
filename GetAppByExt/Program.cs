using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetAppByExt {
    class Program {
        static void Main(string[] args) {
            string pdf = Registry.ClassesRoot.OpenSubKey(Registry.ClassesRoot.OpenSubKey(".pdf").GetValue(null).ToString() + "\\shell\\Open\\command").GetValue(null).ToString();
            string xls = Registry.ClassesRoot.OpenSubKey(Registry.ClassesRoot.OpenSubKey(".xls").GetValue(null).ToString() + "\\shell\\Open\\command").GetValue(null).ToString();
            string docx = Registry.ClassesRoot.OpenSubKey(Registry.ClassesRoot.OpenSubKey(".docx").GetValue(null).ToString() + "\\shell\\Open\\command").GetValue(null).ToString();

            string split = pdf.Split('\"')[1];

            Process.Start(pdf.Split('\"')[1], @"C:\Users\efryscok\Documents\0749_001.pdf");

            bool breakpoint = true;
        }
    }
}
