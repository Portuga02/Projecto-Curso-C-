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
    public partial class frmFuncionario : Form
    {
        public frmFuncionario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cadastro_FuncionariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.cadastro_FuncionariosBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.cadastroFuncionarioDataSet);
                MessageBox.Show("Dados salvo com sucesso ", "Informa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao salvar o registro", "Informa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmFuncionario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cadastroFuncionarioDataSet.Cadastro_Funcionarios' table. You can move, or remove it, as needed.
            this.cadastro_FuncionariosTableAdapter.Fill(this.cadastroFuncionarioDataSet.Cadastro_Funcionarios);

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.cadastro_FuncionariosBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.cadastroFuncionarioDataSet);
                MessageBox.Show("Dados salvo com sucesso ", "Informa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao salvar o registro", "Informa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
