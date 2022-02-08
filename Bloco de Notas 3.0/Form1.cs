using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Bloco_de_Notas_3._0
{
    public partial class Form1 : Form
    {
        private SaveFileDialog salvarDialogo;
        bool alterado;

        public Form1()
        {
            InitializeComponent();
            this.Text = "";
        }

        private void richTextBoxConteudo_TextChanged(object sender, EventArgs e)
        {
            alterado = true;
        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!alterado)
            {
                this.Abrir();
            }
            else
            {
                if (MessageBox.Show("Seu arquivo foi alterado. Deseja salvar?", "Bloco de Notas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    this.Abrir();
                }

                else
                {
                    if (this.Text != "")
                    {
                        //Significa que ja existe um arquivo aberto
                        this.Salvar();
                    }
                    else
                    {
                        //this.SalvarComo(this.Text);
                    }
                }

            }
        }

        private void Abrir()
        {
            if (openFileDialogAbrir.ShowDialog() == DialogResult.OK)
            {
                //Coloca o nome do arquivo como titulo do formulario
                this.Text = openFileDialogAbrir.FileName;
                using (StreamReader reader = new StreamReader(openFileDialogAbrir.OpenFile()))
                {
                    richTextBoxConteudo.Text = reader.ReadToEnd();
                    alterado = false;
                }

            }
        }

        private void Salvar()
        {
            try
            {
                salvarDialogo = new SaveFileDialog();

                if (salvarDialogo.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(salvarDialogo.FileName, this.richTextBoxConteudo.Text);
                    this.Text = salvarDialogo.FileName;
                    alterado = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nome de arquivo inválido!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
               
            }
        }

        private void SalvarComo()
        {
            try
            {
                salvarDialogo = new SaveFileDialog();

                salvarDialogo.Filter = "Arquivo de Texto (*.txt) | *.txt";

                if (salvarDialogo.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(salvarDialogo.FileName, this.richTextBoxConteudo.Text);
                    this.Text = salvarDialogo.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir o arquivo!");
            }
            finally
            {
                
            }
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SalvarComo();
        }

        private void salvarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void desfazerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxConteudo.Undo();
        }

        private void recortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBoxConteudo.SelectedRtf != "")
            {
                Clipboard.SetDataObject(richTextBoxConteudo.SelectedRtf);
                richTextBoxConteudo.SelectedRtf = "";
            }
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(richTextBoxConteudo.SelectedRtf != "")
            {
                Clipboard.SetDataObject(richTextBoxConteudo.SelectedRtf); 
            }
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
            {
                richTextBoxConteudo.SelectedRtf = (String) Clipboard.GetData(DataFormats.Text);
            }
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBoxConteudo.SelectedRtf != "")
            {
                richTextBoxConteudo.SelectedRtf = "";
            }
        }

        private void selecionarTudoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxConteudo.SelectAll();
        }

        private void horaDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxConteudo.SelectedText = System.Environment.NewLine + DateTime.Now;
        }

        private void quebraAutomáticaDeLinhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(quebraAutomáticaDeLinhaToolStripMenuItem.CheckState == CheckState.Checked)
            {
                quebraAutomáticaDeLinhaToolStripMenuItem.CheckState = CheckState.Unchecked;
                richTextBoxConteudo.WordWrap = false;
            }
            else
            {
                quebraAutomáticaDeLinhaToolStripMenuItem.CheckState = CheckState.Checked;
                richTextBoxConteudo.WordWrap = true;
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void configurarPáginaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialogConfiguraPagina.ShowDialog();
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialogImprimir.ShowDialog();
        }

        private void novaJanelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Essa implementação vai transformar em uma janela
            Form1 frm = new Form1();
            //Abre a janela
            frm.Show();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!alterado)
            {
                this.Text = "";
                richTextBoxConteudo.Text = "";
            }
            else
            {
                if (MessageBox.Show("Seu arquivo foi alterado. Deseja Salvar?", "Bloco de Notas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    this.Text = "";
                    richTextBoxConteudo.Text = "";
                }
                else
                {
                    if(this.Text != "")
                    {
                        //Significa que ja existe um arquivo aberto
                        this.Salvar();
                    }
                    else
                    {
                        this.SalvarComo();
                    }

                }
            }
        }
    }
}
