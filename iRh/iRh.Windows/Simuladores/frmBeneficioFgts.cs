using System;
using iRh.Windows.Core;
using System.Windows.Forms;

namespace iRh.Windows.Simuladores
{
    public partial class frmBeneficioFgts : Form
    {
        public frmBeneficioFgts()
        {
            InitializeComponent();
        }

        private void btnCalculaFgts_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSalario.Text))
            {
                MessageBox.Show("Informe um salario válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalario.Focus();
                return;
            }
            else
            {

                try
                {

                    var salario = double.Parse(txtSalario.Text);
                    var fgts = Fgts.Calcula(salario);
                    lblResultado.Text = fgts.ToString("C");
                    panelResultadoFgts.Show();
                }
                catch (Exception)
                {
                    MessageBox.Show("Informe salario ou meses trabalhados válidos.Ex: salario = 2000, meses = 12", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
                }
            }
        }

      
    }
}
