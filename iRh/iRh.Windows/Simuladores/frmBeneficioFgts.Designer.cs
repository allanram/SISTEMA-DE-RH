namespace iRh.Windows.Simuladores
{
    partial class frmBeneficioFgts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBeneficioFgts));
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.btnCalculaFgts = new System.Windows.Forms.Button();
            this.panelResultadoFgts = new System.Windows.Forms.Panel();
            this.lblResultado = new System.Windows.Forms.Label();
            this.panelResultadoFgts.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.Location = new System.Drawing.Point(79, 98);
            this.lblSalario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(168, 25);
            this.lblSalario.TabIndex = 0;
            this.lblSalario.Text = "Digite seu salário:";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(84, 137);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(148, 26);
            this.txtSalario.TabIndex = 1;
            // 
            // btnCalculaFgts
            // 
            this.btnCalculaFgts.Location = new System.Drawing.Point(84, 181);
            this.btnCalculaFgts.Name = "btnCalculaFgts";
            this.btnCalculaFgts.Size = new System.Drawing.Size(137, 30);
            this.btnCalculaFgts.TabIndex = 2;
            this.btnCalculaFgts.Text = "Calcular FGTS";
            this.btnCalculaFgts.UseVisualStyleBackColor = true;
            this.btnCalculaFgts.Click += new System.EventHandler(this.btnCalculaFgts_Click);
            // 
            // panelResultadoFgts
            // 
            this.panelResultadoFgts.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelResultadoFgts.Controls.Add(this.lblResultado);
            this.panelResultadoFgts.Location = new System.Drawing.Point(84, 240);
            this.panelResultadoFgts.Name = "panelResultadoFgts";
            this.panelResultadoFgts.Size = new System.Drawing.Size(310, 106);
            this.panelResultadoFgts.TabIndex = 3;
            this.panelResultadoFgts.Visible = false;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(66, 35);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(100, 25);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "Resultado";
            // 
            // frmBeneficioFgts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(768, 385);
            this.Controls.Add(this.panelResultadoFgts);
            this.Controls.Add(this.btnCalculaFgts);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblSalario);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmBeneficioFgts";
            this.Text = "frmBeneficioFgts";
            this.panelResultadoFgts.ResumeLayout(false);
            this.panelResultadoFgts.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Button btnCalculaFgts;
        private System.Windows.Forms.Panel panelResultadoFgts;
        private System.Windows.Forms.Label lblResultado;
    }
}