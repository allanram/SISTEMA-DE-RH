namespace iRh.Windows.Simuladores
{
    partial class frmBeneficioPericulosidade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBeneficioPericulosidade));
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.panelResultadoPericulosidade = new System.Windows.Forms.Panel();
            this.lblResultadoPericulosidade = new System.Windows.Forms.Label();
            this.btnCalculaPericulosidade = new System.Windows.Forms.Button();
            this.panelResultadoPericulosidade.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.Location = new System.Drawing.Point(43, 80);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(168, 25);
            this.lblSalario.TabIndex = 0;
            this.lblSalario.Text = "Digite seu salario:";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(48, 108);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(153, 20);
            this.txtSalario.TabIndex = 2;
            // 
            // panelResultadoPericulosidade
            // 
            this.panelResultadoPericulosidade.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelResultadoPericulosidade.Controls.Add(this.lblResultadoPericulosidade);
            this.panelResultadoPericulosidade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelResultadoPericulosidade.Location = new System.Drawing.Point(48, 192);
            this.panelResultadoPericulosidade.Name = "panelResultadoPericulosidade";
            this.panelResultadoPericulosidade.Size = new System.Drawing.Size(257, 78);
            this.panelResultadoPericulosidade.TabIndex = 3;
            this.panelResultadoPericulosidade.Visible = false;
            // 
            // lblResultadoPericulosidade
            // 
            this.lblResultadoPericulosidade.AutoSize = true;
            this.lblResultadoPericulosidade.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoPericulosidade.Location = new System.Drawing.Point(4, 24);
            this.lblResultadoPericulosidade.Name = "lblResultadoPericulosidade";
            this.lblResultadoPericulosidade.Size = new System.Drawing.Size(75, 20);
            this.lblResultadoPericulosidade.TabIndex = 0;
            this.lblResultadoPericulosidade.Text = "Resultado";
            // 
            // btnCalculaPericulosidade
            // 
            this.btnCalculaPericulosidade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculaPericulosidade.Location = new System.Drawing.Point(48, 153);
            this.btnCalculaPericulosidade.Name = "btnCalculaPericulosidade";
            this.btnCalculaPericulosidade.Size = new System.Drawing.Size(203, 33);
            this.btnCalculaPericulosidade.TabIndex = 4;
            this.btnCalculaPericulosidade.Text = "Calcular Periculosidade";
            this.btnCalculaPericulosidade.UseVisualStyleBackColor = true;
            this.btnCalculaPericulosidade.Click += new System.EventHandler(this.btnCalculaPericulosidade_Click);
            // 
            // frmBeneficioPericulosidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::iRh.Windows.Properties.Resources.Periculosidade;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(542, 331);
            this.Controls.Add(this.btnCalculaPericulosidade);
            this.Controls.Add(this.panelResultadoPericulosidade);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblSalario);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmBeneficioPericulosidade";
            this.Text = "Beneficio Periculosidade";
            this.panelResultadoPericulosidade.ResumeLayout(false);
            this.panelResultadoPericulosidade.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Panel panelResultadoPericulosidade;
        private System.Windows.Forms.Label lblResultadoPericulosidade;
        private System.Windows.Forms.Button btnCalculaPericulosidade;
    }
}