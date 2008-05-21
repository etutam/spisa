using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace LineCount
{
    class Program
    {
        static int totalCount = 0;

        static void Main(string[] args)
        {
            string path = Environment.CurrentDirectory;
            DirectoryInfo di = new DirectoryInfo(path);
            Console.WriteLine("Line count for all *.cs files in current directory and all subdirectories.");
            ShowProjectLineCount(di);
            Console.WriteLine("Total Project Count: {0}", totalCount);

            Console.ReadLine();
        }

        public static void ShowProjectLineCount(DirectoryInfo d)
        {
            // Curr dir.
            FileInfo[] fis = d.GetFiles("*.cs");
            foreach (FileInfo fi in fis)
            {
                using (StreamReader sr = fi.OpenText())
                {
                    string line;
                    int lineCount = 0;
                    while ((line = sr.ReadLine()) != null)
                    {
                        lineCount++;
                    }
                    totalCount += lineCount;
                    Console.WriteLine("{0} {1}", lineCount, fi.FullName);
                    lineCount = 0;
                }
            }
            // Subdirectories.
            DirectoryInfo[] dis = d.GetDirectories();
            foreach (DirectoryInfo di in dis)
            {
                ShowProjectLineCount(di);
            }
        }
    }
}
