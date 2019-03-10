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
    public partial class frmCadEditora : Form
    {
        public frmCadEditora()
        {
            InitializeComponent();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void editoraBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.editoraCadastradasBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.cadastroEditorasDataSet);
                MessageBox.Show("Cadastro Efetuado com sucesso", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao Registrar no Banco de Dados", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void editoraCadastradasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.editoraCadastradasBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.cadastroEditorasDataSet);
                MessageBox.Show("Cadastro Efetuado com sucesso", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao Registrar no Banco de Dados", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCadEditora_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cadastroEditorasDataSet.EditoraCadastradas' table. You can move, or remove it, as needed.
            this.editoraCadastradasTableAdapter.Fill(this.cadastroEditorasDataSet.EditoraCadastradas);

        }
    }
}
