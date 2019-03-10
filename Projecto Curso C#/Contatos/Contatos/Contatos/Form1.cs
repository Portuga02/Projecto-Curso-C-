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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lista de contatos 1.0\n Sávio Gomes da Silva (Portuga) "); // Pequena descrição da pessoa que fez o sistema
        }

        private void pessoasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pessoasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contadosDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Esta linha de código carrega dados na tabela 'contadosDBDataSet.Pessoas'
            this.pessoasTableAdapter.Fill(this.contadosDBDataSet.Pessoas);

        }

        private void clienteLabel_Click(object sender, EventArgs e)
        {

        }

        private void nomeTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
