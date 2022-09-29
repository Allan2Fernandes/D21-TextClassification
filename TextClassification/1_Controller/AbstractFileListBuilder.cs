using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextClassification.Domain;

namespace TextClassification.Controller
{
    public abstract class AbstractFileListBuilder { 
    
        public abstract List<string> GenerateFileNamesInA();

        public abstract List<string> GenerateFileNamesInB();
        

        //  get the complete FileList-object
        public abstract FileList GetFileList();

    }
}
