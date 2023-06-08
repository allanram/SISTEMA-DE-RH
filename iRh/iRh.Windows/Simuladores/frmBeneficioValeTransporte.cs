using System;
using System.Windows.Forms;
using iRh.Windows.Core;

namespace iRh.Windows.Simuladores
{
    public partial class frmBeneficioValeTransporte : Form
    {
        public frmBeneficioValeTransporte()
        {
            InitializeComponent();
        }

        private void btnCalculaValeTransporte_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtValetransporte.Text))
            {
                MessageBox.Show("Informe um salário", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtValetransporte.Focus();
                return;
            }else
            { 
    
                try
                {
                    var salario = double.Parse(txtValetransporte.Text);
                    var valeTransporte = ValeTrasnporte.Calcula(salario);
                    lblResultado.Text = valeTransporte.ToString("C");
                    panelResultadoValeTransporte.Show();
                }
                catch (Exception)
                {
                    MessageBox.Show("Informe um salario válido", "Atenção Ex: 1850", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                
            }
            
        }
    }
}
