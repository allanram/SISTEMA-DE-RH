using System;
using System.Windows.Forms;
using iRh.Windows.Core;

namespace iRh.Windows.Simuladores
{
    public partial class frmBeneficioFerias : Form
    {
        public frmBeneficioFerias()
        {
            InitializeComponent();
        }

        private void btnCalculaFerias_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtSalario.Text))
            {
                MessageBox.Show("Informe um salario válido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSalario.Focus();
                return;
            }else
            {
                try
                {
                    var salario = double.Parse(txtSalario.Text);
                    var valorFerias = BeneficioFerias.CalculaFerias(salario);
                    lblResultadoFerias.Text = valorFerias.ToString("C");
                    panelResultadoFerias.Show();
                }
                catch (Exception)
                {
                    MessageBox.Show("Informe um salário válido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
                }
            }
            
        }
    }
}
