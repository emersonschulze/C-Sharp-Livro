using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Serialization
{
    public partial class Form1 : Form
    {
        Guy guy1;
        BinaryFormatter formatter = new BinaryFormatter();
        public Form1()
        {
            InitializeComponent();
            guy1 = new Guy(23, "Lulu");
          

            //Cria um arquivo 
            Stream output = File.Create("MyGuy");
            //Serializa o objeto e adiciona ele no aqruivo criado
            formatter.Serialize(output, guy1);
            //Fecha o arquivo
            output.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            //Abre o arquivo com o objeto
            Stream input = File.OpenRead("MyGuy");
            //Desserializa o objeto
            Guy guy = (Guy)formatter.Deserialize(input);
            //Fecha o arquivo
            input.Close();
            //Recupera os valores do objeto na tela
            txtNome.Text = guy.name;
            txtIdade.Text = guy.age.ToString();
        }
    }
}
