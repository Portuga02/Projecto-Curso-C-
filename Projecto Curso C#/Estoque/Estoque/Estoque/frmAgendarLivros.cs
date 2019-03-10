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
    public partial class frmAgendarLivros : Form
    {
        public frmAgendarLivros()
        {
            InitializeComponent();
        }

        private void cadastroLocatariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           try
            {
                this.Validate();
                this.editoraCadastradasBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.cadastroLocatariosDataSet);
                MessageBox.Show("Cadastro Efetuado com sucesso", "INFORMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao Salvar Arquivos!", "INFORMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };

        }

        private void frmAgendarLivros_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cadastroEditorasDataSet.EditoraCadastradas' table. You can move, or remove it, as needed.
            this.editoraCadastradasTableAdapter.Fill(this.cadastroEditorasDataSet.EditoraCadastradas);
            // TODO: This line of code loads data into the 'cadastroLivrosDataSet.LivrosCadastros' table. You can move, or remove it, as needed.
            this.livrosCadastrosTableAdapter.Fill(this.cadastroLivrosDataSet.LivrosCadastros);
            // TODO: This line of code loads data into the 'locacaoDataSet.CadastroLocatarios' table. You can move, or remove it, as needed.
            this.cadastroLocatariosTableAdapter.Fill(this.locacaoDataSet.CadastroLocatarios);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.editoraCadastradasBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.cadastroLocatariosDataSet);
                MessageBox.Show("Cadastro Efetuado com sucesso", "INFORMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao Salvar Arquivos!", "INFORMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public LocacaoDataSet cadastroLocatariosDataSet { get; set; }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
