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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e) // RETORNO DO PAINEL DE USUÁRIOS
        {
            if ((textBox1.Text == "savio") && (textBox2.Text == "123456"))
            {
                frmPrincipal frmp = new frmPrincipal();
                frmp.Show();
                this.Visible = false;
            }
            else 
            {
                MessageBox.Show("Ocorreu um erro! Usuário ou senha não cadastrados ");
            }
        }
    }
}
