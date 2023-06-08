using System;
using iRh.Windows.Core;
using System.Windows.Forms;

namespace iRh.Windows.Simuladores
{
    public partial class frmDescontoIrrf : Form
    {
        public frmDescontoIrrf()
        {
            InitializeComponent();
        }

        private void btnCalculaDescontoIrrf_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtSalario.Text))
            {
                MessageBox.Show("Informe um salario", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalario.Focus();
                return;
            }else
            {
                try
                {
                    var salario = double.Parse(txtSalario.Text);
                    var impostoRenda = ImpostoDeRenda.calculaImpostoDeRenda(salario);
                    var valorImpostoRenda = impostoRenda;
                    lblResultadoImpostoRenda.Text = valorImpostoRenda.ToString("C");
                    panelResultadoImpostoRenda.Show();
                }
                catch (Exception)
                {
                    MessageBox.Show("Informe um salário válido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
            }
            
        }
    }
}
