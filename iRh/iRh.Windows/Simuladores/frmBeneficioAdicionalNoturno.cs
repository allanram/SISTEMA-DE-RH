using System;
using System.Windows.Forms;
using iRh.Windows.Core;

namespace iRh.Windows.Simuladores
{
    public partial class frmBeneficioAdicionalNoturno : Form
    {
        public frmBeneficioAdicionalNoturno()
        {
            InitializeComponent();
        }

        private void btnCalculaAdicionalNoturno_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtSalario.Text))
            {
                MessageBox.Show("Informe um salário", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalario.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtHorasNoturnas.Text))
            {
                MessageBox.Show("Informe um salário", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHorasNoturnas.Focus();
                return;

            }else
            {
                try
                {
                    var salario = double.Parse(txtSalario.Text);
                    var horasNoturnasTrabalhadas = int.Parse(txtHorasNoturnas.Text);
                    var valorHorasNoturnas = AdicionalNoturno.calcula(salario, horasNoturnasTrabalhadas);
                    lblResultadoAdicionalNoturno.Text = valorHorasNoturnas.ToString();
                    panelResultadoAdicionalNoturno.Show();
                }
                catch (Exception)
                {
                    MessageBox.Show("Algum dado colocado não está correto,verifique e tente novamente", "Ex: Salario 1850 Horas Noturnas: 12", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
                }
            }

        }
    }
}
