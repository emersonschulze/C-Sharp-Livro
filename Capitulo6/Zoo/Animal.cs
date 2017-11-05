using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zoo
{
    class Animal
    {
        public PictureBox Figura;
        public bool Comida;
        public int Fome;
        //Referecia
        //Coordenadas

        public void ProduzirSom()
        {

        }

        //Com a palavra virtual no método,significa que o método poderá ser
        //sobreposto pelas classes descendentes
        public virtual void Comer()
        {
            Console.WriteLine("Estou comendo :)");
        }

        public virtual void Dormir()
        {
            Console.WriteLine("Estou dormindo");
        }

        public void Perambular()
        {
            Console.WriteLine("Estou perambulando!");       
        }
    }
}
