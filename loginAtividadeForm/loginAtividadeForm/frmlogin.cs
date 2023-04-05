using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginAtividadeForm
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = tbUsuario.Text;
            string senha = tbSenha.Text;

            if (usuario == "joao" && senha == "123")
            {
                // abrir formulario novo
                frmCalculo fCalculoImc = new frmCalculo();
                this.Hide();
                fCalculoImc.ShowDialog();
                this.Show();
                                
            }
            else
            {
                MessageBox.Show(" Não ta entrado meu patrão, errou a senha ai em hmmm. ");
            }
        }




    }
}
