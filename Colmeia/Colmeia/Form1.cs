using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colmeia
{
    public partial class Form1 : Form
    {
        Queen queen;
        public Form1()
        {
            InitializeComponent();
            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] {"Coletar nectar", "Produção de mel"});
            workers[1] = new Worker(new string[] {"Cuidar dos olhos", "Ensinar as abelhas bebês"});
            workers[2] = new Worker(new string[] { "Manutenção da colméia", "Patrulha" });
            workers[3] = new Worker(new string[] { "Coletar nectar", "Produção de mel", "Cuidar dos ovos", "Ensinar as abelhas bebês", "Manutenção da colméia", "Patrulha"});
            queen = new Queen(workers);
        }

        private void btnProximoTurno_Click(object sender, EventArgs e)
        {
            Relatorio.Text = queen.WorkTheNextShift();
        }

        private void btnAtribuirTarefa_Click(object sender, EventArgs e)
        {
            if(queen.AssignWork(Tarefa.Text, (int)Turnos.Value) == false)
                MessageBox.Show("Não tem operárias disponíveis para o trabalho", "A abelha rainha diz");
            else
                MessageBox.Show("O trabalho "+Tarefa.Text+" irá ser feito em "+Turnos.Value+" turnos", "A abelha rainha diz");

        }
    }
}
