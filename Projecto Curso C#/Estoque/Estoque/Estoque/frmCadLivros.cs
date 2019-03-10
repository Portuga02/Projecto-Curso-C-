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
    public partial class frmCadLivros : Form
    {
        public frmCadLivros()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.livrosCadastrosBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.cadastroLivrosDataSet);
                MessageBox.Show("Cadastro Efetuado com sucesso", "INFORMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Cadastro não Efetuado falha ao salvar arquivos", "INFORMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void livrosCadastrosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.livrosCadastrosBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.cadastroLivrosDataSet);
                MessageBox.Show("Cadastro Efetuado com sucesso", "INFORMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Cadastro não Efetuado falha ao salvar arquivos", "INFORMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmCadLivros_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cadastroLivrosDataSet.LivrosCadastros' table. You can move, or remove it, as needed.
            this.livrosCadastrosTableAdapter.Fill(this.cadastroLivrosDataSet.LivrosCadastros);

        }

        private void comentáriosLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
