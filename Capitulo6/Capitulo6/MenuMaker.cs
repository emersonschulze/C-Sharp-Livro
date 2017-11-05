using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo6
{
    class MenuMaker
    {
        public Random Randomizer;
        string[] carnes = { "Rosbife", "Salami", "Peru", "Presunto", "Pastrami" };
        string[] temperos = { "Mostarda amarela", "mostarde marrom", "mostarda com mel", "maionese", "gosto", "molho francês" };
        string[] paes = { "centeio", "branco", "trigo", "pumpernickel", "pão italiano", "árabe" };

        public string getMenuItem()
        {
            string carneAleatoria = carnes[Randomizer.Next(carnes.Length)];
            string temperoAleatorio = temperos[Randomizer.Next(temperos.Length)];
            string paoAleatorio = paes[Randomizer.Next(paes.Length)];
            return carneAleatoria + " com " + temperoAleatorio + " no " + paoAleatorio;
        }
    }
}
