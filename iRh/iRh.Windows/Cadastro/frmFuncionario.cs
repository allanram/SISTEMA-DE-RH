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
        }

        private void CarregarEstados()
        {
            var estado = new Estados();
            var listaEstados = estado.ObterTodosEstados();
            cmbEstados.Items.Clear();
            cmbEstados.DataSource = listaEstados.OrderBy(x=> x.Sigla);
            cmbEstados.SelectedIndex = 0;
            cmbEstados.DisplayMember = "Sigla";
            cmbEstados.ValueMember = "Id";
            
        }

        

    }
}
