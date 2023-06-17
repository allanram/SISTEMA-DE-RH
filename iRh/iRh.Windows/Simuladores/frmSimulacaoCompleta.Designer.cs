namespace iRh.Windows.Simuladores
{
    partial class frmSimulacaoCompleta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSimulacaoCompleta));
            this.label1 = new System.Windows.Forms.Label();
            this.lblPericulosidade = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblEnunciado = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.MaskedTextBox();
            this.txtHorasExtras = new System.Windows.Forms.MaskedTextBox();
            this.lblValeTransporte = new System.Windows.Forms.Label();
            this.rbUtlizaValeTransporte = new System.Windows.Forms.RadioButton();
            this.rbNaoUtilizaValeTransporte = new System.Windows.Forms.RadioButton();
            this.rbAdicionadoPericulosidade = new System.Windows.Forms.RadioButton();
            this.rbNaoAdicionadoPericulosidade = new System.Windows.Forms.RadioButton();
            this.panelDetalhamentoSimulacaoCompleta = new System.Windows.Forms.Panel();
            this.lblDetalhamentoPericulosidade = new System.Windows.Forms.Label();
            this.lblDetalhamentoHoraExtras = new System.Windows.Forms.Label();
            this.lblDetalhamentoFgts = new System.Windows.Forms.Label();
            this.lblDetalhamentoValeTransporte = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblDetalhamento = new System.Windows.Forms.Label();
            this.lblDetalhamentoNoturno = new System.Windows.Forms.Label();
            this.lblDetalhamentoInss = new System.Windows.Forms.Label();
            this.lblDetalhamentoIrrf = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblDetalhamentoTotalAdicional = new System.Windows.Forms.Label();
            this.lblSalarioLiquido = new System.Windows.Forms.Label();
            this.lblDescontos = new System.Windows.Forms.Label();
            this.lblNoturno = new System.Windows.Forms.Label();
            this.txtNoturno = new System.Windows.Forms.MaskedTextBox();
            this.btnImprimirDetalhamento = new System.Windows.Forms.Button();
            this.lblDetalhamentoValorSalario = new System.Windows.Forms.Label();
            this.lblDetalhamentoValorValeTransporte = new System.Windows.Forms.Label();
            this.lblDetalhamentoValorFgts = new System.Windows.Forms.Label();
            this.lblDetalhamentoValorPericulosidade = new System.Windows.Forms.Label();
            this.lblDetalhamentoValorHoraExtra = new System.Windows.Forms.Label();
            this.lblDetalhamentoValorIrrf = new System.Windows.Forms.Label();
            this.lblDetalhamentoValorInss = new System.Windows.Forms.Label();
            this.lblDetalhamentoValorSalarioLiquido = new System.Windows.Forms.Label();
            this.lblDetalhamentoValorTotalDescontos = new System.Windows.Forms.Label();
            this.lblDetalhamentoValorTotalAdicional = new System.Windows.Forms.Label();
            this.lblDetalhamentoValorNoturno = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelDetalhamentoSimulacaoCompleta.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // lblPericulosidade
            // 
            this.lblPericulosidade.AutoSize = true;
            this.lblPericulosidade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPericulosidade.Location = new System.Drawing.Point(21, 266);
            this.lblPericulosidade.Name = "lblPericulosidade";
            this.lblPericulosidade.Size = new System.Drawing.Size(273, 21);
            this.lblPericulosidade.TabIndex = 1;
            this.lblPericulosidade.Text = "ADICIONADO A PERICULOSIDADE?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "HORAS EXTRAS:";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.Location = new System.Drawing.Point(22, 91);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(246, 21);
            this.lblSalario.TabIndex = 3;
            this.lblSalario.Text = "INFORME SEU SALARIO BRUTO:";
            // 
            // lblEnunciado
            // 
            this.lblEnunciado.AutoSize = true;
            this.lblEnunciado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnunciado.Location = new System.Drawing.Point(21, 53);
            this.lblEnunciado.Name = "lblEnunciado";
            this.lblEnunciado.Size = new System.Drawing.Size(514, 21);
            this.lblEnunciado.TabIndex = 4;
            this.lblEnunciado.Text = "INSIRA OS DADOS ABAIXO PARA IMPRESSÃO DO DETALHAMENTO:";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(26, 125);
            this.txtSalario.Mask = "00000";
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(106, 20);
            this.txtSalario.TabIndex = 5;
            // 
            // txtHorasExtras
            // 
            this.txtHorasExtras.Location = new System.Drawing.Point(25, 178);
            this.txtHorasExtras.Mask = "000";
            this.txtHorasExtras.Name = "txtHorasExtras";
            this.txtHorasExtras.Size = new System.Drawing.Size(119, 20);
            this.txtHorasExtras.TabIndex = 6;
            // 
            // lblValeTransporte
            // 
            this.lblValeTransporte.AutoSize = true;
            this.lblValeTransporte.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValeTransporte.Location = new System.Drawing.Point(23, 211);
            this.lblValeTransporte.Name = "lblValeTransporte";
            this.lblValeTransporte.Size = new System.Drawing.Size(225, 21);
            this.lblValeTransporte.TabIndex = 10;
            this.lblValeTransporte.Text = "UTILIZA VALE TRANSPORTE?";
            // 
            // rbUtlizaValeTransporte
            // 
            this.rbUtlizaValeTransporte.AutoSize = true;
            this.rbUtlizaValeTransporte.Checked = true;
            this.rbUtlizaValeTransporte.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbUtlizaValeTransporte.Location = new System.Drawing.Point(27, 238);
            this.rbUtlizaValeTransporte.Name = "rbUtlizaValeTransporte";
            this.rbUtlizaValeTransporte.Size = new System.Drawing.Size(55, 25);
            this.rbUtlizaValeTransporte.TabIndex = 11;
            this.rbUtlizaValeTransporte.TabStop = true;
            this.rbUtlizaValeTransporte.Tag = "";
            this.rbUtlizaValeTransporte.Text = "SIM";
            this.rbUtlizaValeTransporte.UseVisualStyleBackColor = true;
            this.rbUtlizaValeTransporte.CheckedChanged += new System.EventHandler(this.rbUtlizaValeTransporte_CheckedChanged);
            // 
            // rbNaoUtilizaValeTransporte
            // 
            this.rbNaoUtilizaValeTransporte.AutoSize = true;
            this.rbNaoUtilizaValeTransporte.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNaoUtilizaValeTransporte.Location = new System.Drawing.Point(107, 238);
            this.rbNaoUtilizaValeTransporte.Name = "rbNaoUtilizaValeTransporte";
            this.rbNaoUtilizaValeTransporte.Size = new System.Drawing.Size(62, 25);
            this.rbNaoUtilizaValeTransporte.TabIndex = 12;
            this.rbNaoUtilizaValeTransporte.Text = "NÃO";
            this.rbNaoUtilizaValeTransporte.UseVisualStyleBackColor = true;
            this.rbNaoUtilizaValeTransporte.CheckedChanged += new System.EventHandler(this.rbNaoUtilizaValeTransporte_CheckedChanged);
            // 
            // rbAdicionadoPericulosidade
            // 
            this.rbAdicionadoPericulosidade.AutoSize = true;
            this.rbAdicionadoPericulosidade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAdicionadoPericulosidade.Location = new System.Drawing.Point(6, 6);
            this.rbAdicionadoPericulosidade.Name = "rbAdicionadoPericulosidade";
            this.rbAdicionadoPericulosidade.Size = new System.Drawing.Size(55, 25);
            this.rbAdicionadoPericulosidade.TabIndex = 13;
            this.rbAdicionadoPericulosidade.Tag = "";
            this.rbAdicionadoPericulosidade.Text = "SIM";
            this.rbAdicionadoPericulosidade.UseVisualStyleBackColor = true;
            this.rbAdicionadoPericulosidade.CheckedChanged += new System.EventHandler(this.rbAdicionadoPericulosidade_CheckedChanged);
            // 
            // rbNaoAdicionadoPericulosidade
            // 
            this.rbNaoAdicionadoPericulosidade.AutoSize = true;
            this.rbNaoAdicionadoPericulosidade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNaoAdicionadoPericulosidade.Location = new System.Drawing.Point(67, 6);
            this.rbNaoAdicionadoPericulosidade.Name = "rbNaoAdicionadoPericulosidade";
            this.rbNaoAdicionadoPericulosidade.Size = new System.Drawing.Size(62, 25);
            this.rbNaoAdicionadoPericulosidade.TabIndex = 14;
            this.rbNaoAdicionadoPericulosidade.Text = "NÃO";
            this.rbNaoAdicionadoPericulosidade.UseVisualStyleBackColor = true;
            this.rbNaoAdicionadoPericulosidade.CheckedChanged += new System.EventHandler(this.rbNaoAdicionadoPericulosidade_CheckedChanged);
            // 
            // panelDetalhamentoSimulacaoCompleta
            // 
            this.panelDetalhamentoSimulacaoCompleta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelDetalhamentoSimulacaoCompleta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelDetalhamentoSimulacaoCompleta.Controls.Add(this.lblDetalhamentoValorNoturno);
            this.panelDetalhamentoSimulacaoCompleta.Controls.Add(this.lblDetalhamentoValorTotalAdicional);
            this.panelDetalhamentoSimulacaoCompleta.Controls.Add(this.lblDetalhamentoValorTotalDescontos);
            this.panelDetalhamentoSimulacaoCompleta.Controls.Add(this.lblDetalhamentoValorSalarioLiquido);
            this.panelDetalhamentoSimulacaoCompleta.Controls.Add(this.lblDetalhamentoValorInss);
            this.panelDetalhamentoSimulacaoCompleta.Controls.Add(this.lblDetalhamentoValorIrrf);
            this.panelDetalhamentoSimulacaoCompleta.Controls.Add(this.lblDetalhamentoValorHoraExtra);
            this.panelDetalhamentoSimulacaoCompleta.Controls.Add(this.lblDetalhamentoValorPericulosidade);
            this.panelDetalhamentoSimulacaoCompleta.Controls.Add(this.lblDetalhamentoValorFgts);
            this.panelDetalhamentoSimulacaoCompleta.Controls.Add(this.lblDetalhamentoValorValeTransporte);
            this.panelDetalhamentoSimulacaoCompleta.Controls.Add(this.lblDetalhamentoValorSalario);
            this.panelDetalhamentoSimulacaoCompleta.Controls.Add(this.lblDescontos);
            this.panelDetalhamentoSimulacaoCompleta.Controls.Add(this.lblSalarioLiquido);
            this.panelDetalhamentoSimulacaoCompleta.Controls.Add(this.lblDetalhamentoTotalAdicional);
            this.panelDetalhamentoSimulacaoCompleta.Controls.Add(this.lblResultado);
            this.panelDetalhamentoSimulacaoCompleta.Controls.Add(this.lblDetalhamentoIrrf);
            this.panelDetalhamentoSimulacaoCompleta.Controls.Add(this.lblDetalhamentoInss);
            this.panelDetalhamentoSimulacaoCompleta.Controls.Add(this.lblDetalhamentoNoturno);
            this.panelDetalhamentoSimulacaoCompleta.Controls.Add(this.lblDetalhamentoPericulosidade);
            this.panelDetalhamentoSimulacaoCompleta.Controls.Add(this.lblDetalhamentoHoraExtras);
            this.panelDetalhamentoSimulacaoCompleta.Controls.Add(this.lblDetalhamentoFgts);
            this.panelDetalhamentoSimulacaoCompleta.Controls.Add(this.lblDetalhamentoValeTransporte);
            this.panelDetalhamentoSimulacaoCompleta.Controls.Add(this.lblResult);
            this.panelDetalhamentoSimulacaoCompleta.Controls.Add(this.lblDetalhamento);
            this.panelDetalhamentoSimulacaoCompleta.Location = new System.Drawing.Point(362, 91);
            this.panelDetalhamentoSimulacaoCompleta.Name = "panelDetalhamentoSimulacaoCompleta";
            this.panelDetalhamentoSimulacaoCompleta.Size = new System.Drawing.Size(378, 284);
            this.panelDetalhamentoSimulacaoCompleta.TabIndex = 15;
            // 
            // lblDetalhamentoPericulosidade
            // 
            this.lblDetalhamentoPericulosidade.AutoSize = true;
            this.lblDetalhamentoPericulosidade.Location = new System.Drawing.Point(21, 87);
            this.lblDetalhamentoPericulosidade.Name = "lblDetalhamentoPericulosidade";
            this.lblDetalhamentoPericulosidade.Size = new System.Drawing.Size(114, 13);
            this.lblDetalhamentoPericulosidade.TabIndex = 5;
            this.lblDetalhamentoPericulosidade.Text = "PERICULOSIDASIDE:";
            // 
            // lblDetalhamentoHoraExtras
            // 
            this.lblDetalhamentoHoraExtras.AutoSize = true;
            this.lblDetalhamentoHoraExtras.Location = new System.Drawing.Point(21, 71);
            this.lblDetalhamentoHoraExtras.Name = "lblDetalhamentoHoraExtras";
            this.lblDetalhamentoHoraExtras.Size = new System.Drawing.Size(94, 13);
            this.lblDetalhamentoHoraExtras.TabIndex = 4;
            this.lblDetalhamentoHoraExtras.Text = "HORAS EXTRAS:";
            // 
            // lblDetalhamentoFgts
            // 
            this.lblDetalhamentoFgts.AutoSize = true;
            this.lblDetalhamentoFgts.Location = new System.Drawing.Point(21, 100);
            this.lblDetalhamentoFgts.Name = "lblDetalhamentoFgts";
            this.lblDetalhamentoFgts.Size = new System.Drawing.Size(38, 13);
            this.lblDetalhamentoFgts.TabIndex = 3;
            this.lblDetalhamentoFgts.Text = "FGTS:";
            // 
            // lblDetalhamentoValeTransporte
            // 
            this.lblDetalhamentoValeTransporte.AutoSize = true;
            this.lblDetalhamentoValeTransporte.Location = new System.Drawing.Point(21, 113);
            this.lblDetalhamentoValeTransporte.Name = "lblDetalhamentoValeTransporte";
            this.lblDetalhamentoValeTransporte.Size = new System.Drawing.Size(114, 13);
            this.lblDetalhamentoValeTransporte.TabIndex = 2;
            this.lblDetalhamentoValeTransporte.Text = "VALE TRANSPORTE:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(21, 55);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(104, 13);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "SALARIO BASE: R$";
            // 
            // lblDetalhamento
            // 
            this.lblDetalhamento.AutoSize = true;
            this.lblDetalhamento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalhamento.Location = new System.Drawing.Point(14, 9);
            this.lblDetalhamento.Name = "lblDetalhamento";
            this.lblDetalhamento.Size = new System.Drawing.Size(336, 21);
            this.lblDetalhamento.TabIndex = 0;
            this.lblDetalhamento.Text = "=========DETALHAMENTO=========";
            // 
            // lblDetalhamentoNoturno
            // 
            this.lblDetalhamentoNoturno.AutoSize = true;
            this.lblDetalhamentoNoturno.Location = new System.Drawing.Point(21, 126);
            this.lblDetalhamentoNoturno.Name = "lblDetalhamentoNoturno";
            this.lblDetalhamentoNoturno.Size = new System.Drawing.Size(65, 13);
            this.lblDetalhamentoNoturno.TabIndex = 6;
            this.lblDetalhamentoNoturno.Text = "NOTURNO:";
            // 
            // lblDetalhamentoInss
            // 
            this.lblDetalhamentoInss.AutoSize = true;
            this.lblDetalhamentoInss.Location = new System.Drawing.Point(21, 146);
            this.lblDetalhamentoInss.Name = "lblDetalhamentoInss";
            this.lblDetalhamentoInss.Size = new System.Drawing.Size(35, 13);
            this.lblDetalhamentoInss.TabIndex = 7;
            this.lblDetalhamentoInss.Text = "INSS:";
            // 
            // lblDetalhamentoIrrf
            // 
            this.lblDetalhamentoIrrf.AutoSize = true;
            this.lblDetalhamentoIrrf.Location = new System.Drawing.Point(21, 159);
            this.lblDetalhamentoIrrf.Name = "lblDetalhamentoIrrf";
            this.lblDetalhamentoIrrf.Size = new System.Drawing.Size(35, 13);
            this.lblDetalhamentoIrrf.TabIndex = 8;
            this.lblDetalhamentoIrrf.Text = "IRRF:";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(20, 172);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(314, 20);
            this.lblResultado.TabIndex = 9;
            this.lblResultado.Text = "==========RESULTADO==========";
            // 
            // lblDetalhamentoTotalAdicional
            // 
            this.lblDetalhamentoTotalAdicional.AutoSize = true;
            this.lblDetalhamentoTotalAdicional.Location = new System.Drawing.Point(24, 195);
            this.lblDetalhamentoTotalAdicional.Name = "lblDetalhamentoTotalAdicional";
            this.lblDetalhamentoTotalAdicional.Size = new System.Drawing.Size(105, 13);
            this.lblDetalhamentoTotalAdicional.TabIndex = 10;
            this.lblDetalhamentoTotalAdicional.Text = "TOTAL ADICIONAL:";
            // 
            // lblSalarioLiquido
            // 
            this.lblSalarioLiquido.AutoSize = true;
            this.lblSalarioLiquido.Location = new System.Drawing.Point(24, 247);
            this.lblSalarioLiquido.Name = "lblSalarioLiquido";
            this.lblSalarioLiquido.Size = new System.Drawing.Size(106, 13);
            this.lblSalarioLiquido.TabIndex = 11;
            this.lblSalarioLiquido.Text = "SALÁRIO LÍQUIDO: ";
            // 
            // lblDescontos
            // 
            this.lblDescontos.AutoSize = true;
            this.lblDescontos.Location = new System.Drawing.Point(24, 219);
            this.lblDescontos.Name = "lblDescontos";
            this.lblDescontos.Size = new System.Drawing.Size(115, 13);
            this.lblDescontos.TabIndex = 12;
            this.lblDescontos.Text = "TOTAL DESCONTOS:";
            // 
            // lblNoturno
            // 
            this.lblNoturno.AutoSize = true;
            this.lblNoturno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoturno.Location = new System.Drawing.Point(172, 154);
            this.lblNoturno.Name = "lblNoturno";
            this.lblNoturno.Size = new System.Drawing.Size(94, 21);
            this.lblNoturno.TabIndex = 16;
            this.lblNoturno.Text = "NOTURNO:";
            // 
            // txtNoturno
            // 
            this.txtNoturno.Location = new System.Drawing.Point(176, 178);
            this.txtNoturno.Mask = "000";
            this.txtNoturno.Name = "txtNoturno";
            this.txtNoturno.Size = new System.Drawing.Size(119, 20);
            this.txtNoturno.TabIndex = 17;
            // 
            // btnImprimirDetalhamento
            // 
            this.btnImprimirDetalhamento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirDetalhamento.Location = new System.Drawing.Point(12, 329);
            this.btnImprimirDetalhamento.Name = "btnImprimirDetalhamento";
            this.btnImprimirDetalhamento.Size = new System.Drawing.Size(236, 32);
            this.btnImprimirDetalhamento.TabIndex = 18;
            this.btnImprimirDetalhamento.Text = "IMPRIMIR DETALHAMENTO";
            this.btnImprimirDetalhamento.UseVisualStyleBackColor = true;
            this.btnImprimirDetalhamento.Click += new System.EventHandler(this.btnImprimirDetalhamento_Click);
            // 
            // lblDetalhamentoValorSalario
            // 
            this.lblDetalhamentoValorSalario.AutoSize = true;
            this.lblDetalhamentoValorSalario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblDetalhamentoValorSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalhamentoValorSalario.Location = new System.Drawing.Point(131, 55);
            this.lblDetalhamentoValorSalario.Name = "lblDetalhamentoValorSalario";
            this.lblDetalhamentoValorSalario.Size = new System.Drawing.Size(56, 13);
            this.lblDetalhamentoValorSalario.TabIndex = 13;
            this.lblDetalhamentoValorSalario.Text = "RESULT";
            // 
            // lblDetalhamentoValorValeTransporte
            // 
            this.lblDetalhamentoValorValeTransporte.AutoSize = true;
            this.lblDetalhamentoValorValeTransporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblDetalhamentoValorValeTransporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalhamentoValorValeTransporte.Location = new System.Drawing.Point(141, 113);
            this.lblDetalhamentoValorValeTransporte.Name = "lblDetalhamentoValorValeTransporte";
            this.lblDetalhamentoValorValeTransporte.Size = new System.Drawing.Size(56, 13);
            this.lblDetalhamentoValorValeTransporte.TabIndex = 14;
            this.lblDetalhamentoValorValeTransporte.Text = "RESULT";
            // 
            // lblDetalhamentoValorFgts
            // 
            this.lblDetalhamentoValorFgts.AutoSize = true;
            this.lblDetalhamentoValorFgts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblDetalhamentoValorFgts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalhamentoValorFgts.Location = new System.Drawing.Point(59, 100);
            this.lblDetalhamentoValorFgts.Name = "lblDetalhamentoValorFgts";
            this.lblDetalhamentoValorFgts.Size = new System.Drawing.Size(56, 13);
            this.lblDetalhamentoValorFgts.TabIndex = 15;
            this.lblDetalhamentoValorFgts.Text = "RESULT";
            // 
            // lblDetalhamentoValorPericulosidade
            // 
            this.lblDetalhamentoValorPericulosidade.AutoSize = true;
            this.lblDetalhamentoValorPericulosidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblDetalhamentoValorPericulosidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalhamentoValorPericulosidade.Location = new System.Drawing.Point(131, 87);
            this.lblDetalhamentoValorPericulosidade.Name = "lblDetalhamentoValorPericulosidade";
            this.lblDetalhamentoValorPericulosidade.Size = new System.Drawing.Size(56, 13);
            this.lblDetalhamentoValorPericulosidade.TabIndex = 16;
            this.lblDetalhamentoValorPericulosidade.Text = "RESULT";
            // 
            // lblDetalhamentoValorHoraExtra
            // 
            this.lblDetalhamentoValorHoraExtra.AutoSize = true;
            this.lblDetalhamentoValorHoraExtra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblDetalhamentoValorHoraExtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalhamentoValorHoraExtra.Location = new System.Drawing.Point(121, 69);
            this.lblDetalhamentoValorHoraExtra.Name = "lblDetalhamentoValorHoraExtra";
            this.lblDetalhamentoValorHoraExtra.Size = new System.Drawing.Size(56, 13);
            this.lblDetalhamentoValorHoraExtra.TabIndex = 17;
            this.lblDetalhamentoValorHoraExtra.Text = "RESULT";
            // 
            // lblDetalhamentoValorIrrf
            // 
            this.lblDetalhamentoValorIrrf.AutoSize = true;
            this.lblDetalhamentoValorIrrf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblDetalhamentoValorIrrf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalhamentoValorIrrf.Location = new System.Drawing.Point(59, 161);
            this.lblDetalhamentoValorIrrf.Name = "lblDetalhamentoValorIrrf";
            this.lblDetalhamentoValorIrrf.Size = new System.Drawing.Size(56, 13);
            this.lblDetalhamentoValorIrrf.TabIndex = 18;
            this.lblDetalhamentoValorIrrf.Text = "RESULT";
            // 
            // lblDetalhamentoValorInss
            // 
            this.lblDetalhamentoValorInss.AutoSize = true;
            this.lblDetalhamentoValorInss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblDetalhamentoValorInss.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalhamentoValorInss.Location = new System.Drawing.Point(59, 146);
            this.lblDetalhamentoValorInss.Name = "lblDetalhamentoValorInss";
            this.lblDetalhamentoValorInss.Size = new System.Drawing.Size(56, 13);
            this.lblDetalhamentoValorInss.TabIndex = 19;
            this.lblDetalhamentoValorInss.Text = "RESULT";
            // 
            // lblDetalhamentoValorSalarioLiquido
            // 
            this.lblDetalhamentoValorSalarioLiquido.AutoSize = true;
            this.lblDetalhamentoValorSalarioLiquido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblDetalhamentoValorSalarioLiquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalhamentoValorSalarioLiquido.Location = new System.Drawing.Point(131, 247);
            this.lblDetalhamentoValorSalarioLiquido.Name = "lblDetalhamentoValorSalarioLiquido";
            this.lblDetalhamentoValorSalarioLiquido.Size = new System.Drawing.Size(56, 13);
            this.lblDetalhamentoValorSalarioLiquido.TabIndex = 20;
            this.lblDetalhamentoValorSalarioLiquido.Text = "RESULT";
            // 
            // lblDetalhamentoValorTotalDescontos
            // 
            this.lblDetalhamentoValorTotalDescontos.AutoSize = true;
            this.lblDetalhamentoValorTotalDescontos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblDetalhamentoValorTotalDescontos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalhamentoValorTotalDescontos.Location = new System.Drawing.Point(141, 219);
            this.lblDetalhamentoValorTotalDescontos.Name = "lblDetalhamentoValorTotalDescontos";
            this.lblDetalhamentoValorTotalDescontos.Size = new System.Drawing.Size(56, 13);
            this.lblDetalhamentoValorTotalDescontos.TabIndex = 21;
            this.lblDetalhamentoValorTotalDescontos.Text = "RESULT";
            // 
            // lblDetalhamentoValorTotalAdicional
            // 
            this.lblDetalhamentoValorTotalAdicional.AutoSize = true;
            this.lblDetalhamentoValorTotalAdicional.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblDetalhamentoValorTotalAdicional.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalhamentoValorTotalAdicional.Location = new System.Drawing.Point(131, 192);
            this.lblDetalhamentoValorTotalAdicional.Name = "lblDetalhamentoValorTotalAdicional";
            this.lblDetalhamentoValorTotalAdicional.Size = new System.Drawing.Size(56, 13);
            this.lblDetalhamentoValorTotalAdicional.TabIndex = 22;
            this.lblDetalhamentoValorTotalAdicional.Text = "RESULT";
            // 
            // lblDetalhamentoValorNoturno
            // 
            this.lblDetalhamentoValorNoturno.AutoSize = true;
            this.lblDetalhamentoValorNoturno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblDetalhamentoValorNoturno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalhamentoValorNoturno.Location = new System.Drawing.Point(83, 126);
            this.lblDetalhamentoValorNoturno.Name = "lblDetalhamentoValorNoturno";
            this.lblDetalhamentoValorNoturno.Size = new System.Drawing.Size(56, 13);
            this.lblDetalhamentoValorNoturno.TabIndex = 23;
            this.lblDetalhamentoValorNoturno.Text = "RESULT";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbAdicionadoPericulosidade);
            this.groupBox1.Controls.Add(this.rbNaoAdicionadoPericulosidade);
            this.groupBox1.Location = new System.Drawing.Point(28, 286);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 37);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // frmSimulacaoCompleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnImprimirDetalhamento);
            this.Controls.Add(this.txtNoturno);
            this.Controls.Add(this.lblNoturno);
            this.Controls.Add(this.panelDetalhamentoSimulacaoCompleta);
            this.Controls.Add(this.rbNaoUtilizaValeTransporte);
            this.Controls.Add(this.rbUtlizaValeTransporte);
            this.Controls.Add(this.lblValeTransporte);
            this.Controls.Add(this.txtHorasExtras);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblEnunciado);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPericulosidade);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSimulacaoCompleta";
            this.Text = "SIMULAÇÃO COMPLETA";
            this.Load += new System.EventHandler(this.frmSimulacaoCompleta_Load);
            this.panelDetalhamentoSimulacaoCompleta.ResumeLayout(false);
            this.panelDetalhamentoSimulacaoCompleta.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPericulosidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblEnunciado;
        private System.Windows.Forms.MaskedTextBox txtSalario;
        private System.Windows.Forms.MaskedTextBox txtHorasExtras;
        private System.Windows.Forms.Label lblValeTransporte;
        private System.Windows.Forms.RadioButton rbUtlizaValeTransporte;
        private System.Windows.Forms.RadioButton rbNaoUtilizaValeTransporte;
        private System.Windows.Forms.RadioButton rbAdicionadoPericulosidade;
        private System.Windows.Forms.RadioButton rbNaoAdicionadoPericulosidade;
        private System.Windows.Forms.Panel panelDetalhamentoSimulacaoCompleta;
        private System.Windows.Forms.Label lblDetalhamento;
        private System.Windows.Forms.Label lblDetalhamentoPericulosidade;
        private System.Windows.Forms.Label lblDetalhamentoHoraExtras;
        private System.Windows.Forms.Label lblDetalhamentoFgts;
        private System.Windows.Forms.Label lblDetalhamentoValeTransporte;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblSalarioLiquido;
        private System.Windows.Forms.Label lblDetalhamentoTotalAdicional;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblDetalhamentoIrrf;
        private System.Windows.Forms.Label lblDetalhamentoInss;
        private System.Windows.Forms.Label lblDetalhamentoNoturno;
        private System.Windows.Forms.Label lblDetalhamentoValorNoturno;
        private System.Windows.Forms.Label lblDetalhamentoValorTotalAdicional;
        private System.Windows.Forms.Label lblDetalhamentoValorTotalDescontos;
        private System.Windows.Forms.Label lblDetalhamentoValorSalarioLiquido;
        private System.Windows.Forms.Label lblDetalhamentoValorInss;
        private System.Windows.Forms.Label lblDetalhamentoValorIrrf;
        private System.Windows.Forms.Label lblDetalhamentoValorHoraExtra;
        private System.Windows.Forms.Label lblDetalhamentoValorPericulosidade;
        private System.Windows.Forms.Label lblDetalhamentoValorFgts;
        private System.Windows.Forms.Label lblDetalhamentoValorValeTransporte;
        private System.Windows.Forms.Label lblDetalhamentoValorSalario;
        private System.Windows.Forms.Label lblDescontos;
        private System.Windows.Forms.Label lblNoturno;
        private System.Windows.Forms.MaskedTextBox txtNoturno;
        private System.Windows.Forms.Button btnImprimirDetalhamento;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}