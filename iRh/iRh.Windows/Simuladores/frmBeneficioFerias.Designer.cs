namespace iRh.Windows.Simuladores
{
    partial class frmBeneficioFerias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBeneficioFerias));
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.btnCalculaFerias = new System.Windows.Forms.Button();
            this.panelResultadoFerias = new System.Windows.Forms.Panel();
            this.lblResultadoFerias = new System.Windows.Forms.Label();
            this.panelResultadoFerias.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.Location = new System.Drawing.Point(47, 68);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(168, 25);
            this.lblSalario.TabIndex = 0;
            this.lblSalario.Text = "Digite seu salário:";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(52, 114);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(144, 20);
            this.txtSalario.TabIndex = 1;
            // 
            // btnCalculaFerias
            // 
            this.btnCalculaFerias.FlatAppearance.BorderSize = 0;
            this.btnCalculaFerias.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculaFerias.Location = new System.Drawing.Point(52, 156);
            this.btnCalculaFerias.Name = "btnCalculaFerias";
            this.btnCalculaFerias.Size = new System.Drawing.Size(163, 33);
            this.btnCalculaFerias.TabIndex = 2;
            this.btnCalculaFerias.Text = "Calcular Férias";
            this.btnCalculaFerias.UseVisualStyleBackColor = true;
            this.btnCalculaFerias.Click += new System.EventHandler(this.btnCalculaFerias_Click);
            // 
            // panelResultadoFerias
            // 
            this.panelResultadoFerias.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelResultadoFerias.Controls.Add(this.lblResultadoFerias);
            this.panelResultadoFerias.Location = new System.Drawing.Point(52, 208);
            this.panelResultadoFerias.Name = "panelResultadoFerias";
            this.panelResultadoFerias.Size = new System.Drawing.Size(304, 100);
            this.panelResultadoFerias.TabIndex = 3;
            this.panelResultadoFerias.Visible = false;
            // 
            // lblResultadoFerias
            // 
            this.lblResultadoFerias.AutoSize = true;
            this.lblResultadoFerias.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoFerias.Location = new System.Drawing.Point(23, 35);
            this.lblResultadoFerias.Name = "lblResultadoFerias";
            this.lblResultadoFerias.Size = new System.Drawing.Size(90, 21);
            this.lblResultadoFerias.TabIndex = 4;
            this.lblResultadoFerias.Text = "Resultado:";
            // 
            // frmBeneficioFerias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 342);
            this.Controls.Add(this.panelResultadoFerias);
            this.Controls.Add(this.btnCalculaFerias);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblSalario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBeneficioFerias";
            this.Text = "Beneficio Ferias";
            this.panelResultadoFerias.ResumeLayout(false);
            this.panelResultadoFerias.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Button btnCalculaFerias;
        private System.Windows.Forms.Panel panelResultadoFerias;
        private System.Windows.Forms.Label lblResultadoFerias;
    }
}