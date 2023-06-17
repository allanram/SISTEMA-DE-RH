using System;
using System.Windows.Forms;
using iRh.Windows.Core;

namespace iRh.Windows.Simuladores
{
    public partial class frmSimulacaoCompleta : Form
    {
        public frmSimulacaoCompleta()
        {
            InitializeComponent();
        }

        private void frmSimulacaoCompleta_Load(object sender, EventArgs e)
        {
            panelDetalhamentoSimulacaoCompleta.Visible = false;
            rbAdicionadoPericulosidade.Checked = true;
            rbUtlizaValeTransporte.Checked = true;
        }

        public double RetornaValoresParaDetalhamento()
        {
            



            var salario = double.Parse(txtSalario.Text);
            lblDetalhamentoValorSalario.Text = salario.ToString("C");

            var horasExtras = int.Parse(txtHorasExtras.Text);
            var valorHorasExtras = HorasExtras.CalculaHorasExtras100(salario,horasExtras);
            lblDetalhamentoValorHoraExtra.Text = valorHorasExtras.ToString("C");

            var fgts = Fgts.Calcula(salario);
            lblDetalhamentoValorFgts.Text = fgts.ToString("C");

            var horasNoturnas = int.Parse(txtNoturno.Text);
            var valorNoturno = AdicionalNoturno.calcula(salario,horasNoturnas);
            lblDetalhamentoValorNoturno.Text = valorNoturno.ToString("C");

            var valorValeTransporte = ValeTrasnporte.Calcula(salario);
            lblDetalhamentoValorValeTransporte.Text = valorValeTransporte.ToString("C");

            var valorInss = Inss.Calcula(salario);
            lblDetalhamentoValorInss.Text = valorInss.ToString();

            var valorIrrf = ImpostoDeRenda.calculaImpostoDeRenda(salario);
            lblDetalhamentoValorIrrf.Text = valorIrrf.ToString("C");

            var valorPericulosidade = Periculosidade.CalculaPericulosidade(salario);
            lblDetalhamentoValorPericulosidade.Text = valorPericulosidade.ToString("C");

            var totalAdicional = (valorHorasExtras + valorPericulosidade + valorHorasExtras);
            lblDetalhamentoValorTotalAdicional.Text = totalAdicional.ToString("C");

            var valorSalarioLiquido = (salario + totalAdicional);
            lblDetalhamentoValorSalarioLiquido.Text = valorSalarioLiquido.ToString("C");

            var valorDescontos = (valorIrrf + valorInss + valorValeTransporte);
            lblDetalhamentoValorTotalDescontos.Text = valorDescontos.ToString("C");

            if (rbUtlizaValeTransporte.Checked == false)
            {

                lblDetalhamentoValorValeTransporte.Text = "R$ 0,00";
            }
            if(rbAdicionadoPericulosidade.Checked == false)
            {
                lblDetalhamentoValorPericulosidade.Text = "R$ 0,00";
            }


            return 0;
      
           
              
        }

        private void btnImprimirDetalhamento_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtSalario.Text))
            {
                MessageBox.Show("Informe um salario Válido", "Atenção este campo não foi preenchido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalario.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtNoturno.Text))
            {
                MessageBox.Show("Informe horas Noturnas Válidas", "Atenção este campo não foi preenchido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalario.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtHorasExtras.Text))
            {
                MessageBox.Show("Informe horas Extras Válidas", "Atenção este campo não foi preenchido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalario.Focus();
                return;
            }
            
            else
            {
                try
                {
                    var valoresDetalhamento = RetornaValoresParaDetalhamento();
                    panelDetalhamentoSimulacaoCompleta.Visible = true;

                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void rbUtlizaValeTransporte_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rbNaoUtilizaValeTransporte_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private  void rbAdicionadoPericulosidade_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private  void rbNaoAdicionadoPericulosidade_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
