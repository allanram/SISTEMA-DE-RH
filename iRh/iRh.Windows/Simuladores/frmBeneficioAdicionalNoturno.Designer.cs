namespace iRh.Windows.Simuladores
{
    partial class frmBeneficioAdicionalNoturno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBeneficioAdicionalNoturno));
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblHorasNoturnas = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtHorasNoturnas = new System.Windows.Forms.TextBox();
            this.panelResultadoAdicionalNoturno = new System.Windows.Forms.Panel();
            this.lblResultadoAdicionalNoturno = new System.Windows.Forms.Label();
            this.btnCalculaAdicionalNoturno = new System.Windows.Forms.Button();
            this.panelResultadoAdicionalNoturno.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.Location = new System.Drawing.Point(55, 62);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(168, 25);
            this.lblSalario.TabIndex = 0;
            this.lblSalario.Text = "Digite seu salário:";
            // 
            // lblHorasNoturnas
            // 
            this.lblHorasNoturnas.AutoSize = true;
            this.lblHorasNoturnas.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorasNoturnas.Location = new System.Drawing.Point(55, 113);
            this.lblHorasNoturnas.Name = "lblHorasNoturnas";
            this.lblHorasNoturnas.Size = new System.Drawing.Size(252, 25);
            this.lblHorasNoturnas.TabIndex = 1;
            this.lblHorasNoturnas.Text = "Informe as horas noturnas:";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(60, 90);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(126, 20);
            this.txtSalario.TabIndex = 2;
            // 
            // txtHorasNoturnas
            // 
            this.txtHorasNoturnas.Location = new System.Drawing.Point(60, 141);
            this.txtHorasNoturnas.Name = "txtHorasNoturnas";
            this.txtHorasNoturnas.Size = new System.Drawing.Size(126, 20);
            this.txtHorasNoturnas.TabIndex = 3;
            // 
            // panelResultadoAdicionalNoturno
            // 
            this.panelResultadoAdicionalNoturno.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelResultadoAdicionalNoturno.Controls.Add(this.lblResultadoAdicionalNoturno);
            this.panelResultadoAdicionalNoturno.Location = new System.Drawing.Point(60, 221);
            this.panelResultadoAdicionalNoturno.Name = "panelResultadoAdicionalNoturno";
            this.panelResultadoAdicionalNoturno.Size = new System.Drawing.Size(228, 78);
            this.panelResultadoAdicionalNoturno.TabIndex = 4;
            this.panelResultadoAdicionalNoturno.Visible = false;
            // 
            // lblResultadoAdicionalNoturno
            // 
            this.lblResultadoAdicionalNoturno.AutoSize = true;
            this.lblResultadoAdicionalNoturno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoAdicionalNoturno.Location = new System.Drawing.Point(17, 21);
            this.lblResultadoAdicionalNoturno.Name = "lblResultadoAdicionalNoturno";
            this.lblResultadoAdicionalNoturno.Size = new System.Drawing.Size(86, 21);
            this.lblResultadoAdicionalNoturno.TabIndex = 5;
            this.lblResultadoAdicionalNoturno.Text = "Resultado";
            // 
            // btnCalculaAdicionalNoturno
            // 
            this.btnCalculaAdicionalNoturno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculaAdicionalNoturno.Location = new System.Drawing.Point(60, 168);
            this.btnCalculaAdicionalNoturno.Name = "btnCalculaAdicionalNoturno";
            this.btnCalculaAdicionalNoturno.Size = new System.Drawing.Size(148, 31);
            this.btnCalculaAdicionalNoturno.TabIndex = 5;
            this.btnCalculaAdicionalNoturno.Text = "Calcular Adicional ";
            this.btnCalculaAdicionalNoturno.UseVisualStyleBackColor = true;
            this.btnCalculaAdicionalNoturno.Click += new System.EventHandler(this.btnCalculaAdicionalNoturno_Click);
            // 
            // frmBeneficioAdicionalNoturno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 346);
            this.Controls.Add(this.btnCalculaAdicionalNoturno);
            this.Controls.Add(this.panelResultadoAdicionalNoturno);
            this.Controls.Add(this.txtHorasNoturnas);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblHorasNoturnas);
            this.Controls.Add(this.lblSalario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBeneficioAdicionalNoturno";
            this.Text = "Beneficio Adicional Noturno";
            this.panelResultadoAdicionalNoturno.ResumeLayout(false);
            this.panelResultadoAdicionalNoturno.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblHorasNoturnas;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtHorasNoturnas;
        private System.Windows.Forms.Panel panelResultadoAdicionalNoturno;
        private System.Windows.Forms.Label lblResultadoAdicionalNoturno;
        private System.Windows.Forms.Button btnCalculaAdicionalNoturno;
    }
}