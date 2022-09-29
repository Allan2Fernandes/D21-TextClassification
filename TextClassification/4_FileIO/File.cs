using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextClassification.FileIO
{
    public class File
    {
        // Example of SOLID: Interface segregation
        const string PROJECTPATH = "C:\\Users\\allan\\Downloads\\Working Stuff\\TextClassification\\TextClassification\\bin\\Debug";

        const string AFOLDERNAME = "ClassA";

        const string BFOLDERNAME = "ClassB";

        // This method is doing too much split it up using a static service in _5 Foundation
        public static List<string> getAllFileNames(string folder)
        {
            
            List<string> fileNames = new List<string>(); // the return
            /*
            Debug.WriteLine("folder name is " + folder);
            if (!folder.Equals(AFOLDERNAME))
            {
                Debug.WriteLine("Return A");
                return fileNames;
            }
            else if (!folder.Equals(BFOLDERNAME))
            {
                Debug.WriteLine("Return B");
                return fileNames;
            }
            */
            string FullPath = Path.Combine(PROJECTPATH, folder);
            
            string[] files = Directory.GetFiles(FullPath, "*.txt");
           
            // TODO: REFACTOR (MOVE) THIS CODE TO A Fundation class (string operations
            foreach (var file in files)
            {
                string name = Path.GetFileName(file);

                name = name.Substring(0, name.Length - 4);
                fileNames.Add(name);
            }
            fileNames.ForEach(file => Debug.WriteLine(file));
            return fileNames;
        }
    }
}
