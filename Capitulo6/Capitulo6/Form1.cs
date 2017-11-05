using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capitulo6
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        BirthdayParty birthdayParty;

        public Form1()
        {
            InitializeComponent();

            dinnerParty = new DinnerParty((int)nuJantar.Value, cbDecoracaoJantar.Checked, cbJantarSaudavel.Checked);
            DisplayDinnerPartyCost();

            //birthdayParty = new BirthdayParty((int)numFestaAniversario.Value, cbDecoracaoAniversario.Checked);
            //DisplayBirthdayPartyCost();

            GeradorDeMenu();
            
        }

        //Eventos do gerador de menus
        private void btnGerador_Click(object sender, EventArgs e)
        {
            GeradorDeMenu();
        }
        
        private void GeradorDeMenu()
        {
            //Gerador de menu
            MenuMaker criadorDeMenu = new MenuMaker() { Randomizer = new Random() };
            label1.Text = criadorDeMenu.getMenuItem();
            label2.Text = criadorDeMenu.getMenuItem();
            label3.Text = criadorDeMenu.getMenuItem();
            label4.Text = criadorDeMenu.getMenuItem();
            label5.Text = criadorDeMenu.getMenuItem();
            label6.Text = criadorDeMenu.getMenuItem();
        }


        //Eventos da tab de Jantar
        private void nuJantar_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)nuJantar.Value;
            DisplayDinnerPartyCost();
        }

        private void cbDecoracaoJantar_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.CalculateCostOfDecoration(cbDecoracaoJantar.Checked);
            DisplayDinnerPartyCost();
        }

        private void cbJantarSaudavel_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.SetHealthyOption(cbJantarSaudavel.Checked);
            DisplayDinnerPartyCost();
        }
        
        private void DisplayDinnerPartyCost()
        {
            decimal cost = dinnerParty.CalculateCost();
            lblCustoJantar.Text = cost.ToString("c");
        }


        //Eventos da tab de Aniversário
        private void DisplayBirthdayPartyCost()
        {
            decimal cost = birthdayParty.CalculateCost();
            lblCustoAniversario.Text = cost.ToString("c");
        }

        private void cbDecoracaoAniversario_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.CalculateCostOfDecoration(cbDecoracaoJantar.Checked);
            DisplayBirthdayPartyCost();
        }

        private void numFestaAniversario_ValueChanged(object sender, EventArgs e)
        {
            birthdayParty.NumberOfPeople = (int)numFestaAniversario.Value;
            DisplayBirthdayPartyCost();
        }
    }
}
