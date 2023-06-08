using System;
using System.Windows.Forms;
using iRh.Windows.Core;

namespace iRh.Windows.Simuladores
{
    public partial class frmBeneficioPis : Form
    {
        public frmBeneficioPis()
        {
            InitializeComponent();
        }

        private void btnCalculaPis_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtSalario.Text))
            {
                MessageBox.Show("Informe um salario.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalario.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtMesesTrabalhados.Text))
            {
                MessageBox.Show("Informe um salario.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMesesTrabalhados.Focus();
                return;
            }
            else
            {
                try
                {
                    var salario = double.Parse(txtSalario.Text);
                    var mesesTrabalhados = double.Parse(txtMesesTrabalhados.Text);
                    var valorPis = Pis.CalculaPis(salario, mesesTrabalhados);
                    if(valorPis == 0)
                    {
                        lblResultadoPis.Text = ("Sinto muito voce não tem direito ao beneficio Pis:(");
                        panelResultadoPis.Show();
                    }
                    else
                    {
                        lblResultadoPis.Text = valorPis.ToString("C");
                        panelResultadoPis.Show();
                    
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Informe um salario e/ou Meses válidos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
                }
            }
        }
    }
}
