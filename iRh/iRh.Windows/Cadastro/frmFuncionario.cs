using System.Windows.Forms;
using System;

namespace iRh.Windows.Cadastro
{
    public partial class frmFuncionario : Form
    {
        public frmFuncionario()
        {
            InitializeComponent();
        }

        private void frmFuncionario_Load(object sender, System.EventArgs e)
        {
            rbTemFilhosNao.Checked = true;
            panelExibeDadosFilhos.Visible = false;


        }

        private void rbTemFilhosSim_CheckedChanged(object sender, System.EventArgs e)
        {
            panelExibeDadosFilhos.Visible = true;

        }

        private void rbTemFilhosNao_CheckedChanged(object sender, System.EventArgs e)
        {
            panelExibeDadosFilhos.Visible = false;
        }

       

        private void txtFilhoDataNascimento_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                try
                {
                    var dataNascimento = DateTime.Parse(txtFilhoDataNascimento.Text);
                    var anoAtual = DateTime.Now.Year;

                    lblIdade.Text = (anoAtual - dataNascimento.Year).ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("A data de Nascimento informada esta incorreta: " + ex.Message);
                    
                }
                
            }
        }

    }
}
