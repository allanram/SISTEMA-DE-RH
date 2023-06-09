﻿using iRh.Windows.Core;
using System;
using System.Windows.Forms;


namespace iRh.Windows.Simuladores
{
    public partial class frmDescontoInss : Form
    {
        //CONSTRUTOR
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
                var descontoInss = Inss.Calcula(salario);
                lblResultado.Text = descontoInss.ToString("C");
                panelResultado.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Informe um salario Válido Ex.1300","Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSalario.Focus();
                
            }
            
            
        }

       
    }
}
