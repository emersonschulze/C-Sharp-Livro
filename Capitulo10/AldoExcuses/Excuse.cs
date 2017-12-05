using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AldoExcuses
{
    class Excuse
    {
        public string Description;
        public DateTime LastUsed;
        public string ExcusePath;
        public string Results;  

        //Três diferentes contrutores
        public Excuse()
        {

        }

        public Excuse (string excusePath)
        {
            OpenFile(excusePath);
        }

        public Excuse(Random random, string folder)
        {
            string[] fileNames = Directory.GetFiles(folder, "*.txt");
            OpenFile(fileNames[random.Next(fileNames.Length)]);
        }
        
        /*Método utilizado para abrir um arquivo, nele o caminho já 
        é selecionado no Form1 e enviado como um parâmetro string.*/
        public void OpenFile(string excusePath)
        {
            this.ExcusePath = excusePath;
            using (StreamReader reader = new StreamReader(excusePath))
            {
                Description = reader.ReadLine();
                Results = reader.ReadLine();
                LastUsed = Convert.ToDateTime(reader.ReadLine());
            }
        }

        /*Método utilizado para salvar o arquivo, ele recebe como 
        parâmetro o nome do arquivo*/
        public void Save(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine(Description);
                writer.WriteLine(Results);
                writer.WriteLine(LastUsed.ToString());
            }
        }
    }
}
