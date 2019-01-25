using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class IndexFile
    {
        private int nameLength;
        private int size;
        private string name;
        private string homeDir;

        public IndexFile(string name, string homeDir)
        {
            this.name = name;
            this.homeDir = homeDir;
        }

        public void getLength()
        {
            getNameLenght();
        }

        private void getNameLenght()
        {
            nameLength = name.LastIndexOf(".");
        }
    }
}
