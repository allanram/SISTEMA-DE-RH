namespace iRh.Windows.Simuladores
{
    partial class frmBeneficioSeguroDesemprego
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBeneficioSeguroDesemprego));
            this.panelResultadoSeguroDesemprego = new System.Windows.Forms.Panel();
            this.lblResultadoSeguroDesemprego = new System.Windows.Forms.Label();
            this.txtSalario1 = new System.Windows.Forms.TextBox();
            this.lblSalario1 = new System.Windows.Forms.Label();
            this.btnCalculaSeguroDesemprego = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSalario2 = new System.Windows.Forms.TextBox();
            this.txtSalario3 = new System.Windows.Forms.TextBox();
            this.panelResultadoSeguroDesemprego.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelResultadoSeguroDesemprego
            // 
            this.panelResultadoSeguroDesemprego.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelResultadoSeguroDesemprego.Controls.Add(this.lblResultadoSeguroDesemprego);
            this.panelResultadoSeguroDesemprego.Location = new System.Drawing.Point(192, 233);
            this.panelResultadoSeguroDesemprego.Name = "panelResultadoSeguroDesemprego";
            this.panelResultadoSeguroDesemprego.Size = new System.Drawing.Size(189, 57);
            this.panelResultadoSeguroDesemprego.TabIndex = 0;
            this.panelResultadoSeguroDesemprego.Visible = false;
            // 
            // lblResultadoSeguroDesemprego
            // 
            this.lblResultadoSeguroDesemprego.AutoSize = true;
            this.lblResultadoSeguroDesemprego.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoSeguroDesemprego.Location = new System.Drawing.Point(21, 19);
            this.lblResultadoSeguroDesemprego.Name = "lblResultadoSeguroDesemprego";
            this.lblResultadoSeguroDesemprego.Size = new System.Drawing.Size(79, 21);
            this.lblResultadoSeguroDesemprego.TabIndex = 0;
            this.lblResultadoSeguroDesemprego.Text = "Resultado";
            // 
            // txtSalario1
            // 
            this.txtSalario1.Location = new System.Drawing.Point(38, 104);
            this.txtSalario1.Name = "txtSalario1";
            this.txtSalario1.Size = new System.Drawing.Size(100, 20);
            this.txtSalario1.TabIndex = 1;
            // 
            // lblSalario1
            // 
            this.lblSalario1.AutoSize = true;
            this.lblSalario1.Location = new System.Drawing.Point(35, 88);
            this.lblSalario1.Name = "lblSalario1";
            this.lblSalario1.Size = new System.Drawing.Size(51, 13);
            this.lblSalario1.TabIndex = 2;
            this.lblSalario1.Text = "Salario 1:";
            // 
            // btnCalculaSeguroDesemprego
            // 
            this.btnCalculaSeguroDesemprego.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculaSeguroDesemprego.Location = new System.Drawing.Point(38, 208);
            this.btnCalculaSeguroDesemprego.Name = "btnCalculaSeguroDesemprego";
            this.btnCalculaSeguroDesemprego.Size = new System.Drawing.Size(115, 35);
            this.btnCalculaSeguroDesemprego.TabIndex = 3;
            this.btnCalculaSeguroDesemprego.Text = "Calcular";
            this.btnCalculaSeguroDesemprego.UseVisualStyleBackColor = true;
            this.btnCalculaSeguroDesemprego.Click += new System.EventHandler(this.btnCalculaSeguroDesemprego_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(35, 52);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(346, 25);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Informe o valor dos 3 ultimos salários";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Salario 3:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Salario2:";
            // 
            // txtSalario2
            // 
            this.txtSalario2.Location = new System.Drawing.Point(38, 143);
            this.txtSalario2.Name = "txtSalario2";
            this.txtSalario2.Size = new System.Drawing.Size(100, 20);
            this.txtSalario2.TabIndex = 7;
            // 
            // txtSalario3
            // 
            this.txtSalario3.Location = new System.Drawing.Point(38, 182);
            this.txtSalario3.Name = "txtSalario3";
            this.txtSalario3.Size = new System.Drawing.Size(100, 20);
            this.txtSalario3.TabIndex = 8;
            // 
            // frmBeneficioSeguroDesemprego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::iRh.Windows.Properties.Resources.SeguroDesemprego;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(553, 319);
            this.Controls.Add(this.txtSalario3);
            this.Controls.Add(this.txtSalario2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnCalculaSeguroDesemprego);
            this.Controls.Add(this.lblSalario1);
            this.Controls.Add(this.txtSalario1);
            this.Controls.Add(this.panelResultadoSeguroDesemprego);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmBeneficioSeguroDesemprego";
            this.Text = "Beneficio Seguro Desemprego";
            this.panelResultadoSeguroDesemprego.ResumeLayout(false);
            this.panelResultadoSeguroDesemprego.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelResultadoSeguroDesemprego;
        private System.Windows.Forms.TextBox txtSalario1;
        private System.Windows.Forms.Label lblSalario1;
        private System.Windows.Forms.Button btnCalculaSeguroDesemprego;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblResultadoSeguroDesemprego;
        private System.Windows.Forms.TextBox txtSalario2;
        private System.Windows.Forms.TextBox txtSalario3;
    }
}