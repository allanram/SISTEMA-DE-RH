namespace iRh.Windows.Simuladores
{
    partial class frmBeneficioHoraExtra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBeneficioHoraExtra));
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHorasExtras = new System.Windows.Forms.TextBox();
            this.rbEnvolve = new System.Windows.Forms.RadioButton();
            this.rbNaoEnvolve = new System.Windows.Forms.RadioButton();
            this.lblPergunta = new System.Windows.Forms.Label();
            this.panelResultadoBeneficioHoraExtra = new System.Windows.Forms.Panel();
            this.lblResultado = new System.Windows.Forms.Label();
            this.panelResultadoBeneficioHoraExtra.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.Location = new System.Drawing.Point(40, 76);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(168, 25);
            this.lblSalario.TabIndex = 0;
            this.lblSalario.Text = "Digite seu salario:";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(45, 119);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(142, 20);
            this.txtSalario.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(232, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Informe as Horas Extras:";
            // 
            // txtHorasExtras
            // 
            this.txtHorasExtras.Location = new System.Drawing.Point(253, 119);
            this.txtHorasExtras.Name = "txtHorasExtras";
            this.txtHorasExtras.Size = new System.Drawing.Size(136, 20);
            this.txtHorasExtras.TabIndex = 3;
            // 
            // rbEnvolve
            // 
            this.rbEnvolve.AutoSize = true;
            this.rbEnvolve.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEnvolve.Location = new System.Drawing.Point(45, 200);
            this.rbEnvolve.Name = "rbEnvolve";
            this.rbEnvolve.Size = new System.Drawing.Size(55, 25);
            this.rbEnvolve.TabIndex = 6;
            this.rbEnvolve.TabStop = true;
            this.rbEnvolve.Text = "SIM";
            this.rbEnvolve.UseVisualStyleBackColor = true;
            this.rbEnvolve.CheckedChanged += new System.EventHandler(this.rbEnvolve_CheckedChanged);
            // 
            // rbNaoEnvolve
            // 
            this.rbNaoEnvolve.AutoSize = true;
            this.rbNaoEnvolve.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNaoEnvolve.Location = new System.Drawing.Point(139, 200);
            this.rbNaoEnvolve.Name = "rbNaoEnvolve";
            this.rbNaoEnvolve.Size = new System.Drawing.Size(62, 25);
            this.rbNaoEnvolve.TabIndex = 7;
            this.rbNaoEnvolve.TabStop = true;
            this.rbNaoEnvolve.Text = "NÃO";
            this.rbNaoEnvolve.UseVisualStyleBackColor = true;
            this.rbNaoEnvolve.CheckedChanged += new System.EventHandler(this.rbNaoEnvolve_CheckedChanged);
            // 
            // lblPergunta
            // 
            this.lblPergunta.AutoSize = true;
            this.lblPergunta.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPergunta.Location = new System.Drawing.Point(40, 155);
            this.lblPergunta.Name = "lblPergunta";
            this.lblPergunta.Size = new System.Drawing.Size(488, 25);
            this.lblPergunta.TabIndex = 8;
            this.lblPergunta.Text = "As horas extras envolvem finais de semana e feriados?";
            // 
            // panelResultadoBeneficioHoraExtra
            // 
            this.panelResultadoBeneficioHoraExtra.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelResultadoBeneficioHoraExtra.Controls.Add(this.lblResultado);
            this.panelResultadoBeneficioHoraExtra.Location = new System.Drawing.Point(45, 231);
            this.panelResultadoBeneficioHoraExtra.Name = "panelResultadoBeneficioHoraExtra";
            this.panelResultadoBeneficioHoraExtra.Size = new System.Drawing.Size(310, 100);
            this.panelResultadoBeneficioHoraExtra.TabIndex = 9;
            this.panelResultadoBeneficioHoraExtra.Visible = false;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(20, 36);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(79, 21);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.Text = "Resultado";
            // 
            // frmBeneficioHoraExtra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 423);
            this.Controls.Add(this.panelResultadoBeneficioHoraExtra);
            this.Controls.Add(this.lblPergunta);
            this.Controls.Add(this.rbNaoEnvolve);
            this.Controls.Add(this.rbEnvolve);
            this.Controls.Add(this.txtHorasExtras);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblSalario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBeneficioHoraExtra";
            this.Text = "Beneficio Hora Extra";
            this.Load += new System.EventHandler(this.frmBeneficioHoraExtra_Load);
            this.panelResultadoBeneficioHoraExtra.ResumeLayout(false);
            this.panelResultadoBeneficioHoraExtra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHorasExtras;
        private System.Windows.Forms.RadioButton rbEnvolve;
        private System.Windows.Forms.RadioButton rbNaoEnvolve;
        private System.Windows.Forms.Label lblPergunta;
        private System.Windows.Forms.Panel panelResultadoBeneficioHoraExtra;
        private System.Windows.Forms.Label lblResultado;
    }
}