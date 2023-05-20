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
    public partial class frmDescontoInss : Form
    {
        public frmDescontoInss()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtSalario.Text))
            {
                MessageBox.Show("Informe seu salario base", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtSalario.Focus();
                return;
            }
           
            try
            {
                var salario = double.Parse(txtSalario.Text);
                
            }
            catch (Exception)
            {
                MessageBox.Show("Informe um salario Válido Ex.1300","Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSalario.Focus();
                throw;
            }
        }
    }
}
