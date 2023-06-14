using iRh.Windows.Core;
using System.Linq;
using System.Windows.Forms;


namespace iRh.Windows.Cadastro
{
    public partial class frmFuncionario : Form
    {
        public frmFuncionario()
        {
            InitializeComponent();
        }

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
            var endereco = new Endereco();
            var enderecoCompleto = endereco.obterPorCep(cepDigitado);

        }
    }
}
