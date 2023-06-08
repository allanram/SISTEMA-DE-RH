using System;
using System.Windows.Forms;
using iRh.Windows.Core;

namespace iRh.Windows.Simuladores
{
    public partial class frmBeneficioPericulosidade : Form
    {
        public frmBeneficioPericulosidade()
        {
            InitializeComponent();
        }

        private void btnCalculaPericulosidade_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtSalario.Text))
            {
                MessageBox.Show("Informe um salario válido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                var salario = double.Parse(txtSalario.Text);
                var totalPericulosidade = Periculosidade.CalculaPericulosidade(salario);
                lblResultadoPericulosidade.Text = totalPericulosidade.ToString("C");
                panelResultadoPericulosidade.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Informe um saário válido.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }
    }
}
