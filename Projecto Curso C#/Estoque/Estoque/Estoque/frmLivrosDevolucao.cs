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
    public partial class frmLivrosDevolucao : Form
    {
        public frmLivrosDevolucao()
        {
            InitializeComponent();
        }

        private void editoraCadastradasBindingNavigatorSaveItem_Click(object sender, EventArgs e) // Salvamento de Livros (Part do cadastramento
        {
            this.Validate();
            this.livrosDevolucaoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.LivrosDevolucaoDataSet);

        }

        private void frmLivrosDevolucao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'livrosDevolucaoDataSet.LivrosDevolucao' table. You can move, or remove it, as needed.
            this.livrosDevolucaoTableAdapter.Fill(this.livrosDevolucaoDataSet.LivrosDevolucao);
            // TODO: This line of code loads data into the 'cadastroEditorasDataSet.EditoraCadastradas' table. You can move, or remove it, as needed.
            this.editoraCadastradasTableAdapter.Fill(this.cadastroEditorasDataSet.EditoraCadastradas);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.livrosDevolucaoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.LivrosDevolucaoDataSet);
            MessageBox.Show("Cadastro Efetuado com sucesso", "INFORMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public CadastroEditorasDataSet LivrosDevolucaoDataSet { get; set; }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
