using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nasledovanie_practic
{
    public class File
    {
        private string fileName;
        private double size;       

        public string FileName { get => fileName; set => fileName = value; }
        public double Size { get => size; set => size = value; }
 
        public File(File buf)
        {
            FileName = buf.FileName;
            size = buf.Size;
        }
        public File(string name,double size)
        {
            Size = size;
            FileName = name;
        }
        public File() { }
        public static File  operator-(File fq){
            return new File { FileName=fq.FileName,Size=fq.Size };
        }

    }
}
