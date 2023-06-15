using iRh.Windows.Core;
using System;
using System.Linq;
using System.Windows.Forms;


namespace iRh.Windows.Cadastro
{
    public partial class frmFuncionario : Form
    {


        public int MaxLength { get; set; }
        public frmFuncionario()
        {
            InitializeComponent();
        }


        // a usuabilidade (Enabled) permite controle dos campos aonde o usuario pode ou nao alterar
        private void frmFuncionario_Load(object sender, System.EventArgs e)
        {
            CarregarEstados();
            CarregarDocumentosDeIdentificacao();
            
        }

        private void CarregarEstados()
        {
            var estado = new Estados();
            var listaEstados = estado.ObterTodosEstados();
            cmbEstados.Items.Clear();
            cmbEstados.DataSource = listaEstados.OrderBy(x => x.Sigla).ToList();
            cmbEstados.SelectedIndex = 0;
            cmbEstados.DisplayMember = "Nome";
            cmbEstados.ValueMember = "Sigla";
           

        }
        private void CarregarDocumentosDeIdentificacao()
        {
           var documentos = new DocumentosIdentificacao();
           var listaDocumentos = documentos.ObterTodosDocumentos();
           cmbDocumentoDeIdentificacao.Items.Clear();
           cmbDocumentoDeIdentificacao.DataSource = listaDocumentos.OrderBy(x => x.Id).ToList();
           cmbDocumentoDeIdentificacao.SelectedIndex = 0;
           cmbDocumentoDeIdentificacao.DisplayMember = "Descricao";
           cmbDocumentoDeIdentificacao.ValueMember = "Id";

        }


       
       
        private void btnPesquisar_Click(object sender, System.EventArgs e)
        {
            var cepDigitado = txtCep.Text;
            if (cepDigitado.Length < 9)
            {
                MessageBox.Show("Informe um CEP válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCep.Focus();
                return;
            }
            var endereco = new Endereco();
            var enderecoCompleto = endereco.ObterPorCep(cepDigitado);
            if(enderecoCompleto.Erro == true)
            {
                MessageBox.Show("O CEP digitado não existe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCep.Focus();
                return;
            }
            if(enderecoCompleto.Localidade != "")
            {
                txtCidade.Enabled = false;
            }
            if(enderecoCompleto.Uf!= "")
            {
                cmbEstados.Enabled = false;
            }
            txtLogradouro.Text = enderecoCompleto.Logradouro;
            txtBairro.Text = enderecoCompleto.Bairro;
            txtCidade.Text = enderecoCompleto.Localidade;
            TxtDdd.Text = enderecoCompleto.Ddd;
            cmbEstados.SelectedValue = enderecoCompleto.Uf;

            
        }


       
    }
}
