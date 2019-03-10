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
    public partial class frmLocatario : Form
    {
        public frmLocatario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.editoraCadastradasBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.cadastroEditorasDataSet);
                MessageBox.Show("Cadastro Efetuado com sucesso", "INFORMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao Salvar Arquivos!", "INFORMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLocatario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cadastroLocadoresDataSet.CadastrosLocadores' table. You can move, or remove it, as needed.
            this.cadastrosLocadoresTableAdapter.Fill(this.cadastroLocadoresDataSet.CadastrosLocadores);
            // TODO: This line of code loads data into the 'locacaoDataSet.CadastroLocatarios' table. You can move, or remove it, as needed.
            this.cadastroLocatariosTableAdapter.Fill(this.locacaoDataSet.CadastroLocatarios);
            // TODO: This line of code loads data into the 'cadastroEditorasDataSet.EditoraCadastradas' table. You can move, or remove it, as needed.
            this.editoraCadastradasTableAdapter.Fill(this.cadastroEditorasDataSet.EditoraCadastradas);

        }

        private void editoraCadastradasBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {

        }
    }
}
