using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace notas
{
    class FileMember
    {
        public string path;
        public int distance;
        public string directory;

        public FileMember(string directory, string path, int distance = 99)
        {
            this.directory = directory;
            this.path = path;
            this.distance = distance;
        }

        public override string ToString()
        {
            return this.fileName();
        }

        public string fileName()
        {
            return this.path.Replace(this.directory, "");
        }
    }
}
