using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextClassification.Domain;

namespace TextClassification.Controller
{
    public class FileListBuilder:AbstractFileListBuilder
    {
        private FileList _fileList;

        public FileListBuilder()
        {
            _fileList = new FileList();
        }

        public override FileList GetFileList()
        {
            return _fileList;
        }

        // THIS METHOD NEEDS REFACTORING...
        public override List<string> GenerateFileNamesInA()
        {
            List<string> res = new List<string>();

            // List<string> fileA = getAllFileNames("ClassA");


            return res;
        }

        public override List<string> GenerateFileNamesInB()
        {
            throw new NotImplementedException();
        }
    }
}
