using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AldoExcuses
{
    public partial class Form1 : Form
    {
        bool clearForm = false;

        //Objeto criado
        private Excuse currentExcuse = new Excuse();

        //Pasta que será selecionada a partir do botão btnFolder
        private string selectedfolder = "";

        //Estado inicial do fomrulário (Sem mudanças)
        private bool formChanged = false;
        
        //Geração de um objeto random
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

       

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Se caixas de texto estiverem vazias
            if(String.IsNullOrEmpty(txtExcuse.Text) || String.IsNullOrEmpty(txtResults.Text))
            {
                MessageBox.Show("Por favor digite uma desculpa ou um resultado válido!", "Impossível salvar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            /*Pega o diretório selecionado através do botão btnFolder
             e utiliza ele no objeto saveFileDialog1, que abre uma janela de
              diálogo utilizada para salvar arquivos no windows, em seguida define
              os filtros da janela, e depois o método save é chamado
            */
            saveFileDialog1.InitialDirectory = selectedfolder;
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FileName = txtExcuse.Text+".txt";
            DialogResult result = saveFileDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                currentExcuse.Save(saveFileDialog1.FileName);
                UpdateForm(false);
                MessageBox.Show("Desculpa salva", "Aviso");
            }

        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            //Seleciona a pasta selecionada
            folderBrowserDialog1.SelectedPath = selectedfolder;
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                selectedfolder = folderBrowserDialog1.SelectedPath;
                //Os outros botões serão habilitados
                btnOpen.Enabled = true;
                btnSave.Enabled = true;
                btnRandom.Enabled = true;

            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (CheckChanged())
            {
                openFileDialog1.InitialDirectory = selectedfolder;
                openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog1.FileName = txtExcuse.Text + ".txt";
                DialogResult result = openFileDialog1.ShowDialog();
                if (result == DialogResult.OK)
                 
                try
                {
                    currentExcuse = new Excuse(openFileDialog1.FileName);
                    try
                    {
                        UpdateForm(false);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("O arquivo de desculpas é inválido");
                        clearForm = true;
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Um erro ocorreu durante a abertura da desculpa\n"
                        +openFileDialog1.FileName+"\n"+ex.Message,"Impossível abrir desculpa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        clearForm = true;
                   
                }
                    finally
                    {
                        if (clearForm)
                        {
                            txtExcuse.Text = "";
                            txtResults.Text = "";
                            dpLastUsed.Value = DateTime.Now;
                        }
                    }

                
                {
                    
                   
                }
            }
        }

        private void UpdateForm(bool Changed)
        {
            if (!Changed)
            {
                this.txtExcuse.Text = currentExcuse.Description;
                this.txtResults.Text = currentExcuse.Results;
                this.dpLastUsed.Value = currentExcuse.LastUsed;
                if (!String.IsNullOrEmpty(currentExcuse.ExcusePath))
                    lblDate.Text = File.GetLastWriteTime(currentExcuse.ExcusePath).ToString();
                this.Text = "Gerenciador de desculpas";
            }
            else
            {
                this.Text = "Gerenciador de desculpas*";
            }
            this.formChanged = Changed;
        }

        private bool CheckChanged()
        {
            if (formChanged)
            {
                DialogResult result = MessageBox.Show(
                    "A desculpa atual não foi salva. Deseja continuar?", "Aviso",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(result == DialogResult.No)
                {
                    return false;
                }
            }
            return true;
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            if (CheckChanged())
            {
                currentExcuse = new Excuse(random, selectedfolder);
                UpdateForm(false);
            }
        }

        private void txtExcuse_TextChanged(object sender, EventArgs e)
        {
            currentExcuse.Description = txtExcuse.Text;
            UpdateForm(true);
        }

        private void txtResults_TextChanged(object sender, EventArgs e)
        {
            currentExcuse.Results = txtResults.Text;
            UpdateForm(true);
        }

        private void dpLastUsed_ValueChanged(object sender, EventArgs e)
        {
            currentExcuse.LastUsed = dpLastUsed.Value;
            UpdateForm(true);
        }
    }
}
