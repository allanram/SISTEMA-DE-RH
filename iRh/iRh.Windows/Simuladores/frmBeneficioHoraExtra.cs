using System;
using System.Windows.Forms;
using iRh.Windows.Core;

namespace iRh.Windows.Simuladores
{
    public partial class frmBeneficioHoraExtra : Form
    {
        public frmBeneficioHoraExtra()
        {
            InitializeComponent();
        }
        private void frmBeneficioHoraExtra_Load(object sender, EventArgs e)
        {
            rbNaoEnvolve.Checked = true;
            panelResultadoBeneficioHoraExtra.Visible = false;

        }

        
        private void rbNaoEnvolve_CheckedChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSalario.Text))
            {
                MessageBox.Show("Insira um salário valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalario.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtHorasExtras.Text))
            {
                MessageBox.Show("Insira horas válidas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHorasExtras.Focus();
                return;
            }

            try
            {
                var salario = double.Parse(txtSalario.Text);
                var horasExtras = int.Parse(txtHorasExtras.Text);
                var totalHorasExtras = HorasExtras.CalculaHorasExtras50(salario, horasExtras);
                lblResultado.Text = totalHorasExtras.ToString();
                panelResultadoBeneficioHoraExtra.Show();


            }
            catch (Exception)
            {
                MessageBox.Show("Informe um salário ou Horas Extras válidos.Exemplo \n, salario = 3455, horas = 24", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

              
            }

        }

        private void rbEnvolve_CheckedChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSalario.Text))
            {
                MessageBox.Show("Insira um salário valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalario.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtHorasExtras.Text))
            {
                MessageBox.Show("Insira horas válidas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHorasExtras.Focus();
                return;
            }

            try
            {
                var salario = double.Parse(txtSalario.Text);
                var horasExtras = int.Parse(txtHorasExtras.Text);
                var totalHorasExtras = HorasExtras.CalculaHorasExtras100(salario, horasExtras);
                lblResultado.Text = totalHorasExtras.ToString();
                panelResultadoBeneficioHoraExtra.Show();

            }
            catch (Exception)
            {
                MessageBox.Show("Informe um salário ou Horas Extras válidos.Exemplo \n, salario = 3455, horas = 24", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
        }

       
    }
}
