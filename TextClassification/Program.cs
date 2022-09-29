using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextClassification.Controller;
using TextClassification.Domain;
using TextClassification.FileIO;

namespace TextClassification
{
    class Program
    {
        // This is a way to trigger contoller actions later from a WPF
        static void Main(string[] args)
        {
            
            File.getAllFileNames("ClassA");
            FileListBuilder flb = new FileListBuilder();

            flb.GenerateFileNamesInA();

            FileList fl = flb.GetFileList();

            
            List<string> files = fl.GetA();

            
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }
            

            
            Console.Read();
        }
    }
}
