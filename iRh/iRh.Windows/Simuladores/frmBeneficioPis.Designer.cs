namespace iRh.Windows.Simuladores
{
    partial class frmBeneficioPis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.btnCalculaPis = new System.Windows.Forms.Button();
            this.panelResultadoPis = new System.Windows.Forms.Panel();
            this.lblResultadoPis = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMesesTrabalhados = new System.Windows.Forms.TextBox();
            this.panelResultadoPis.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.Location = new System.Drawing.Point(32, 68);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(187, 25);
            this.lblSalario.TabIndex = 0;
            this.lblSalario.Text = "Informe seu salário:";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(40, 107);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(168, 20);
            this.txtSalario.TabIndex = 1;
            // 
            // btnCalculaPis
            // 
            this.btnCalculaPis.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculaPis.Location = new System.Drawing.Point(37, 181);
            this.btnCalculaPis.Name = "btnCalculaPis";
            this.btnCalculaPis.Size = new System.Drawing.Size(129, 31);
            this.btnCalculaPis.TabIndex = 2;
            this.btnCalculaPis.Text = "Calcular Pis";
            this.btnCalculaPis.UseVisualStyleBackColor = true;
            this.btnCalculaPis.Click += new System.EventHandler(this.btnCalculaPis_Click);
            // 
            // panelResultadoPis
            // 
            this.panelResultadoPis.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelResultadoPis.Controls.Add(this.lblResultadoPis);
            this.panelResultadoPis.Location = new System.Drawing.Point(40, 240);
            this.panelResultadoPis.Name = "panelResultadoPis";
            this.panelResultadoPis.Size = new System.Drawing.Size(210, 74);
            this.panelResultadoPis.TabIndex = 3;
            this.panelResultadoPis.Visible = false;
            // 
            // lblResultadoPis
            // 
            this.lblResultadoPis.AutoSize = true;
            this.lblResultadoPis.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoPis.Location = new System.Drawing.Point(13, 18);
            this.lblResultadoPis.Name = "lblResultadoPis";
            this.lblResultadoPis.Size = new System.Drawing.Size(86, 21);
            this.lblResultadoPis.TabIndex = 4;
            this.lblResultadoPis.Text = "Resultado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Informe seu salário:";
            // 
            // txtMesesTrabalhados
            // 
            this.txtMesesTrabalhados.Location = new System.Drawing.Point(244, 107);
            this.txtMesesTrabalhados.Name = "txtMesesTrabalhados";
            this.txtMesesTrabalhados.Size = new System.Drawing.Size(168, 20);
            this.txtMesesTrabalhados.TabIndex = 5;
            // 
            // frmBeneficioPis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 383);
            this.Controls.Add(this.txtMesesTrabalhados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelResultadoPis);
            this.Controls.Add(this.btnCalculaPis);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblSalario);
            this.Name = "frmBeneficioPis";
            this.Text = "frmBeneficioPis";
            this.panelResultadoPis.ResumeLayout(false);
            this.panelResultadoPis.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Button btnCalculaPis;
        private System.Windows.Forms.Panel panelResultadoPis;
        private System.Windows.Forms.Label lblResultadoPis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMesesTrabalhados;
    }
}