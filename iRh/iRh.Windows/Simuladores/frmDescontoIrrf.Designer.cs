namespace iRh.Windows.Simuladores
{
    partial class frmDescontoIrrf
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
            this.btnCalculaDescontoIrrf = new System.Windows.Forms.Button();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.Location = new System.Drawing.Point(52, 77);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(168, 25);
            this.lblSalario.TabIndex = 0;
            this.lblSalario.Text = "Digite seu salário:";
            // 
            // btnCalculaDescontoIrrf
            // 
            this.btnCalculaDescontoIrrf.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculaDescontoIrrf.Location = new System.Drawing.Point(46, 150);
            this.btnCalculaDescontoIrrf.Name = "btnCalculaDescontoIrrf";
            this.btnCalculaDescontoIrrf.Size = new System.Drawing.Size(174, 30);
            this.btnCalculaDescontoIrrf.TabIndex = 1;
            this.btnCalculaDescontoIrrf.Text = "Calcular Desconto";
            this.btnCalculaDescontoIrrf.UseVisualStyleBackColor = true;
            this.btnCalculaDescontoIrrf.Click += new System.EventHandler(this.btnCalculaDescontoIrrf_Click);
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(55, 111);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(147, 20);
            this.txtSalario.TabIndex = 2;
            // 
            // frmDescontoIrrf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.btnCalculaDescontoIrrf);
            this.Controls.Add(this.lblSalario);
            this.Name = "frmDescontoIrrf";
            this.Text = "Desconto Imposto de Renda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Button btnCalculaDescontoIrrf;
        private System.Windows.Forms.TextBox txtSalario;
    }
}