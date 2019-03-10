using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToShortDateString();
            toolStripStatusLabel3.Text = DateTime.Now.ToShortTimeString();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        } 
        private void frmPrincipal_Closed(object sender, FormClosedEventArgs e) 
        {
            Application.Exit();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e) // LEGENDA PARA OS BOTÕES
        {

        }

        private void publisheToolStripMenuItem_Click(object sender, EventArgs e) //Executa o Microsoft Publisher
        {
            System.Diagnostics.Process.Start("win");
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e) // Executa a Calculadora do Sistema
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e) // Executa O Microsoft Word do Sistema
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)// Executa O Microsoft Excel do Sistema
        {
            System.Diagnostics.Process.Start("winexcel");
        }

        private void powerPointToolStripMenuItem_Click(object sender, EventArgs e)// Executa O Microsoft Power Point do Sistema
        {
            System.Diagnostics.Process.Start("winpowerpoint");
        }

        private void acessToolStripMenuItem_Click(object sender, EventArgs e)// Executa O Microsoft Access do Sistema
        {
            System.Diagnostics.Process.Start("winaccess");
        }

        private void oneNoteToolStripMenuItem_Click(object sender, EventArgs e)// Executa O Microsoft One Note do Sistema
        {
            System.Diagnostics.Process.Start("winonenote");
        }

        private void adobeToolStripMenuItem_Click(object sender, EventArgs e)// Executa O Adobe  do Sistema
        {
            System.Diagnostics.Process.Start("winadobe");
        }

        private void livrosToolStripMenuItem_Click(object sender, EventArgs e) // Conecção com o formulário de cadastro de livros
        {
            frmCadLivros frmcl = new frmCadLivros();
            frmcl.Show();
        }

        private void locatariosToolStripMenuItem_Click(object sender, EventArgs e) // Cadastro dos Locatários
        {
            frmLocatario frmloc = new frmLocatario();
            frmloc.Show();
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e) // Cadastro de funcinarios
        {
            frmFuncionario frmfunc = new frmFuncionario();
            frmfunc.Show();
        }

        
        private void editorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadEditora frmcadEditora = new frmCadEditora();
            frmcadEditora.Show();
        }
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            frmLivrosDevolucao frmLivroDevolucao = new frmLivrosDevolucao();
            frmLivroDevolucao.Show();
        }

        private void frmAgendarLivros_Load(object sender, EventArgs e)
        {

        }

        private void frmAgendarLivrostoolStripButton8_Click(object sender, EventArgs e)
        {
            frmAgendarLivros frmfrmAgendarLivros = new frmAgendarLivros();
            frmfrmAgendarLivros.Show();
        }

        private void DevoluçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLivrosDevolucao frmLivroDevolucao = new frmLivrosDevolucao();
            frmLivroDevolucao.Show();
        }

        private void locatáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
