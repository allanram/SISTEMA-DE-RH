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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBeneficioPis));
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.btnCalculaPis = new System.Windows.Forms.Button();
            this.panelResultadoPis = new System.Windows.Forms.Panel();
            this.lblResultadoPis = new System.Windows.Forms.Label();
            this.lblMesesTrabalhados = new System.Windows.Forms.Label();
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
            this.btnCalculaPis.Location = new System.Drawing.Point(40, 164);
            this.btnCalculaPis.Name = "btnCalculaPis";
            this.btnCalculaPis.Size = new System.Drawing.Size(129, 31);
            this.btnCalculaPis.TabIndex = 2;
            this.btnCalculaPis.Text = "Calcular Pis";
            this.btnCalculaPis.UseVisualStyleBackColor = true;
            this.btnCalculaPis.Click += new System.EventHandler(this.btnCalculaPis_Click);
            // 
            // panelResultadoPis
            // 
            this.panelResultadoPis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelResultadoPis.Controls.Add(this.lblResultadoPis);
            this.panelResultadoPis.Location = new System.Drawing.Point(40, 201);
            this.panelResultadoPis.Name = "panelResultadoPis";
            this.panelResultadoPis.Size = new System.Drawing.Size(372, 51);
            this.panelResultadoPis.TabIndex = 3;
            this.panelResultadoPis.Visible = false;
            // 
            // lblResultadoPis
            // 
            this.lblResultadoPis.AutoSize = true;
            this.lblResultadoPis.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoPis.Location = new System.Drawing.Point(12, 15);
            this.lblResultadoPis.Name = "lblResultadoPis";
            this.lblResultadoPis.Size = new System.Drawing.Size(79, 20);
            this.lblResultadoPis.TabIndex = 4;
            this.lblResultadoPis.Text = "Resultado";
            // 
            // lblMesesTrabalhados
            // 
            this.lblMesesTrabalhados.AutoSize = true;
            this.lblMesesTrabalhados.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesesTrabalhados.Location = new System.Drawing.Point(225, 68);
            this.lblMesesTrabalhados.Name = "lblMesesTrabalhados";
            this.lblMesesTrabalhados.Size = new System.Drawing.Size(282, 25);
            this.lblMesesTrabalhados.TabIndex = 4;
            this.lblMesesTrabalhados.Text = "Informe os meses trabalhados:";
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
            this.BackgroundImage = global::iRh.Windows.Properties.Resources.Pis;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(544, 323);
            this.Controls.Add(this.txtMesesTrabalhados);
            this.Controls.Add(this.lblMesesTrabalhados);
            this.Controls.Add(this.panelResultadoPis);
            this.Controls.Add(this.btnCalculaPis);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblSalario);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBeneficioPis";
            this.Text = "Beneficio Pis";
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
        private System.Windows.Forms.Label lblMesesTrabalhados;
        private System.Windows.Forms.TextBox txtMesesTrabalhados;
    }
}