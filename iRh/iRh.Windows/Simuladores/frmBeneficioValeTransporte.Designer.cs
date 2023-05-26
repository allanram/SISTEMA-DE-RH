namespace iRh.Windows.Simuladores
{
    partial class frmBeneficioValeTransporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBeneficioValeTransporte));
            this.lblValeTransporte = new System.Windows.Forms.Label();
            this.btnCalculaValeTransporte = new System.Windows.Forms.Button();
            this.panelResultadoValeTransporte = new System.Windows.Forms.Panel();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtValetransporte = new System.Windows.Forms.TextBox();
            this.panelResultadoValeTransporte.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblValeTransporte
            // 
            this.lblValeTransporte.AutoSize = true;
            this.lblValeTransporte.Location = new System.Drawing.Point(58, 68);
            this.lblValeTransporte.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblValeTransporte.Name = "lblValeTransporte";
            this.lblValeTransporte.Size = new System.Drawing.Size(187, 25);
            this.lblValeTransporte.TabIndex = 0;
            this.lblValeTransporte.Text = "Informe seu salário:";
            // 
            // btnCalculaValeTransporte
            // 
            this.btnCalculaValeTransporte.Location = new System.Drawing.Point(63, 184);
            this.btnCalculaValeTransporte.Name = "btnCalculaValeTransporte";
            this.btnCalculaValeTransporte.Size = new System.Drawing.Size(242, 30);
            this.btnCalculaValeTransporte.TabIndex = 1;
            this.btnCalculaValeTransporte.Text = "Calcular Vale Transporte";
            this.btnCalculaValeTransporte.UseVisualStyleBackColor = true;
            this.btnCalculaValeTransporte.Click += new System.EventHandler(this.btnCalculaValeTransporte_Click);
            // 
            // panelResultadoValeTransporte
            // 
            this.panelResultadoValeTransporte.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelResultadoValeTransporte.Controls.Add(this.lblResultado);
            this.panelResultadoValeTransporte.Location = new System.Drawing.Point(63, 240);
            this.panelResultadoValeTransporte.Name = "panelResultadoValeTransporte";
            this.panelResultadoValeTransporte.Size = new System.Drawing.Size(258, 74);
            this.panelResultadoValeTransporte.TabIndex = 2;
            this.panelResultadoValeTransporte.Visible = false;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(38, 26);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(100, 25);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "Resultado";
            // 
            // txtValetransporte
            // 
            this.txtValetransporte.Location = new System.Drawing.Point(63, 120);
            this.txtValetransporte.Name = "txtValetransporte";
            this.txtValetransporte.Size = new System.Drawing.Size(170, 33);
            this.txtValetransporte.TabIndex = 3;
            // 
            // frmBeneficioValeTransporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::iRh.Windows.Properties.Resources.valeTransporteImagem;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(505, 441);
            this.Controls.Add(this.txtValetransporte);
            this.Controls.Add(this.panelResultadoValeTransporte);
            this.Controls.Add(this.btnCalculaValeTransporte);
            this.Controls.Add(this.lblValeTransporte);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmBeneficioValeTransporte";
            this.Text = "frmBeneficioValeTransporte";
            this.panelResultadoValeTransporte.ResumeLayout(false);
            this.panelResultadoValeTransporte.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValeTransporte;
        private System.Windows.Forms.Button btnCalculaValeTransporte;
        private System.Windows.Forms.Panel panelResultadoValeTransporte;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtValetransporte;
    }
}