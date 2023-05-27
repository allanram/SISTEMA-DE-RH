namespace iRh.Windows.Cadastro
{
    partial class frmFuncionario
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
            this.cmbGerero = new System.Windows.Forms.ComboBox();
            this.rbTemFilhosSim = new System.Windows.Forms.RadioButton();
            this.rbTemFilhosNao = new System.Windows.Forms.RadioButton();
            this.lblPergunta = new System.Windows.Forms.Label();
            this.txtFilhoNome = new System.Windows.Forms.TextBox();
            this.lblFilhoNome = new System.Windows.Forms.Label();
            this.lblFilhoDataNascimento = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.panelExibeDadosFilhos = new System.Windows.Forms.Panel();
            this.txtFilhoDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.panelExibeDadosFilhos.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbGerero
            // 
            this.cmbGerero.FormattingEnabled = true;
            this.cmbGerero.Items.AddRange(new object[] {
            "Femenino",
            "masculino",
            "Binario",
            "Polifractal de Genero",
            "Ceterogenero",
            "Trans masculino",
            "Trans feminino",
            "Não decici"});
            this.cmbGerero.Location = new System.Drawing.Point(54, 87);
            this.cmbGerero.Name = "cmbGerero";
            this.cmbGerero.Size = new System.Drawing.Size(147, 21);
            this.cmbGerero.TabIndex = 0;
            // 
            // rbTemFilhosSim
            // 
            this.rbTemFilhosSim.AutoSize = true;
            this.rbTemFilhosSim.Location = new System.Drawing.Point(54, 166);
            this.rbTemFilhosSim.Name = "rbTemFilhosSim";
            this.rbTemFilhosSim.Size = new System.Drawing.Size(42, 17);
            this.rbTemFilhosSim.TabIndex = 1;
            this.rbTemFilhosSim.TabStop = true;
            this.rbTemFilhosSim.Text = "Sim";
            this.rbTemFilhosSim.UseVisualStyleBackColor = true;
            this.rbTemFilhosSim.CheckedChanged += new System.EventHandler(this.rbTemFilhosSim_CheckedChanged);
            // 
            // rbTemFilhosNao
            // 
            this.rbTemFilhosNao.AutoSize = true;
            this.rbTemFilhosNao.Location = new System.Drawing.Point(102, 166);
            this.rbTemFilhosNao.Name = "rbTemFilhosNao";
            this.rbTemFilhosNao.Size = new System.Drawing.Size(45, 17);
            this.rbTemFilhosNao.TabIndex = 2;
            this.rbTemFilhosNao.TabStop = true;
            this.rbTemFilhosNao.Text = "Não";
            this.rbTemFilhosNao.UseVisualStyleBackColor = true;
            this.rbTemFilhosNao.CheckedChanged += new System.EventHandler(this.rbTemFilhosNao_CheckedChanged);
            // 
            // lblPergunta
            // 
            this.lblPergunta.AutoSize = true;
            this.lblPergunta.Location = new System.Drawing.Point(51, 150);
            this.lblPergunta.Name = "lblPergunta";
            this.lblPergunta.Size = new System.Drawing.Size(85, 13);
            this.lblPergunta.TabIndex = 3;
            this.lblPergunta.Text = "Voce tem filhos?";
            // 
            // txtFilhoNome
            // 
            this.txtFilhoNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFilhoNome.Location = new System.Drawing.Point(6, 25);
            this.txtFilhoNome.Name = "txtFilhoNome";
            this.txtFilhoNome.Size = new System.Drawing.Size(100, 20);
            this.txtFilhoNome.TabIndex = 4;
            // 
            // lblFilhoNome
            // 
            this.lblFilhoNome.AutoSize = true;
            this.lblFilhoNome.Location = new System.Drawing.Point(3, 9);
            this.lblFilhoNome.Name = "lblFilhoNome";
            this.lblFilhoNome.Size = new System.Drawing.Size(92, 13);
            this.lblFilhoNome.TabIndex = 6;
            this.lblFilhoNome.Text = "Nome do seu filho";
            // 
            // lblFilhoDataNascimento
            // 
            this.lblFilhoDataNascimento.AutoSize = true;
            this.lblFilhoDataNascimento.Location = new System.Drawing.Point(130, 9);
            this.lblFilhoDataNascimento.Name = "lblFilhoDataNascimento";
            this.lblFilhoDataNascimento.Size = new System.Drawing.Size(104, 13);
            this.lblFilhoDataNascimento.TabIndex = 7;
            this.lblFilhoDataNascimento.Text = "Data de Nascimento";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(226, 28);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(44, 13);
            this.lblIdade.TabIndex = 8;
            this.lblIdade.Text = "lblIdade";
            // 
            // panelExibeDadosFilhos
            // 
            this.panelExibeDadosFilhos.Controls.Add(this.txtFilhoDataNascimento);
            this.panelExibeDadosFilhos.Controls.Add(this.lblIdade);
            this.panelExibeDadosFilhos.Controls.Add(this.txtFilhoNome);
            this.panelExibeDadosFilhos.Controls.Add(this.lblFilhoDataNascimento);
            this.panelExibeDadosFilhos.Controls.Add(this.lblFilhoNome);
            this.panelExibeDadosFilhos.Location = new System.Drawing.Point(27, 205);
            this.panelExibeDadosFilhos.Name = "panelExibeDadosFilhos";
            this.panelExibeDadosFilhos.Size = new System.Drawing.Size(286, 51);
            this.panelExibeDadosFilhos.TabIndex = 9;
            // 
            // txtFilhoDataNascimento
            // 
            this.txtFilhoDataNascimento.Location = new System.Drawing.Point(133, 25);
            this.txtFilhoDataNascimento.Mask = "00/00/0000";
            this.txtFilhoDataNascimento.Name = "txtFilhoDataNascimento";
            this.txtFilhoDataNascimento.Size = new System.Drawing.Size(67, 20);
            this.txtFilhoDataNascimento.TabIndex = 9;
            this.txtFilhoDataNascimento.ValidatingType = typeof(System.DateTime);
            this.txtFilhoDataNascimento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFilhoDataNascimento_KeyDown);
            // 
            // frmFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelExibeDadosFilhos);
            this.Controls.Add(this.lblPergunta);
            this.Controls.Add(this.rbTemFilhosNao);
            this.Controls.Add(this.rbTemFilhosSim);
            this.Controls.Add(this.cmbGerero);
            this.Name = "frmFuncionario";
            this.Text = "frmFuncionario";
            this.Load += new System.EventHandler(this.frmFuncionario_Load);
            this.panelExibeDadosFilhos.ResumeLayout(false);
            this.panelExibeDadosFilhos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbGerero;
        private System.Windows.Forms.RadioButton rbTemFilhosSim;
        private System.Windows.Forms.RadioButton rbTemFilhosNao;
        private System.Windows.Forms.Label lblPergunta;
        private System.Windows.Forms.TextBox txtFilhoNome;
        private System.Windows.Forms.Label lblFilhoNome;
        private System.Windows.Forms.Label lblFilhoDataNascimento;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Panel panelExibeDadosFilhos;
        private System.Windows.Forms.MaskedTextBox txtFilhoDataNascimento;
    }
}