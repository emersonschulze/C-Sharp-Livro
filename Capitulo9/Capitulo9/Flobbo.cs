using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Capitulo9
{
    class Flobbo
    {
        private string Zap;

        public Flobbo(string Zap)
        {
            this.Zap = Zap;
        }

        public StreamWriter Snobbo()
        {
            return new StreamWriter("macaw.txt");
        }

        public bool Blobbo(bool Already, StreamWriter sw)
        {
            if (Already)
            {
                sw.WriteLine(Zap);
                sw.Close();
                return false;
                
            }
            else
            {
                sw.WriteLine(Zap);
                Zap = "green purple";
                return false;
            }
        }

        public bool Blobbo(StreamWriter sw)
        {
            sw.WriteLine(Zap);
            Zap = "red orange";
            return true;
            
            
        }
    }
}
