using System.Windows.Forms;
using iRh.Windows.Core;

namespace iRh.Windows.Simuladores
{
    public partial class frmBeneficioSeguroDesemprego : Form
    {
        public frmBeneficioSeguroDesemprego()
        {
            InitializeComponent();
        }

        private void btnCalculaSeguroDesemprego_Click(object sender, System.EventArgs e)
        {
            if(string.IsNullOrEmpty(txtSalario1.Text))
            {
                MessageBox.Show("Informe um salario valido.", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalario1.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtSalario2.Text))
            {
                MessageBox.Show("Informe um salario valido.", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalario2.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtSalario3.Text))
            {
                MessageBox.Show("Informe um salario valido.", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalario3.Focus();
                return;
            }
            else
            {
                try
                {
                    var salario1 = double.Parse(txtSalario1.Text);
                    var salario2 = double.Parse(txtSalario2.Text);
                    var salario3 = double.Parse(txtSalario3.Text);
                    var valorSeguroDesemprego = SeguroDesemprego.CalculaSeguroDesemprego(salario1, salario2, salario3);
                    lblResultadoSeguroDesemprego.Text = valorSeguroDesemprego.ToString("C");
                    panelResultadoSeguroDesemprego.Show();
                }
                catch (System.Exception)
                {
                    MessageBox.Show("Informe um salario válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
                }
            }
        }

       
    }
}
