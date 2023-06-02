using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iRh.Windows.Simuladores
{
    public partial class frmBeneficioHoraExtra : Form
    {
        public frmBeneficioHoraExtra()
        {
            InitializeComponent();
        }

        private void btnCalculaValorHoraExtra_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtSalario.Text))
            {
                MessageBox.Show("Insira um salário valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalario.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtHorasExtras.Text))
            {
                MessageBox.Show("Insira horas válidas","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHorasExtras.Focus();
                return;
            }
            try
            {
                var salario = double.Parse(txtSalario.Text);
                var horasExtras = int.Parse(txtHorasExtras.Text);

            }
            catch (Exception)
            {

                throw;
            }


        }
         
        
    }
}
