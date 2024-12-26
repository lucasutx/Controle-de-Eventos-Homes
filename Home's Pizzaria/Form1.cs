using System.Globalization;
namespace Home_s_Pizzaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cadastrar cad = new Cadastrar(txtNome.Text, txtEndereco.Text, txtTelefone.Text, txtEmail.Text, double.Parse(txtValor.Text));

            MessageBox.Show(cad.msg);

            txtNome.Text = "";
            txtEndereco.Text = "";
            txtTelefone.Text = "";
            txtEmail.Text = "";
            txtValor.Text = "";

        }

        private void btnSoma_Click(object sender, EventArgs e)
        {

            SubTotal sb = new SubTotal(dtpDataInicio.Text, dtpDataFim.Text);
            /*MessageBox.Show(sb.msg);*/
            dtpDataInicio.Text = "";
            dtpDataFim.Text = "";

            MessageBox.Show(
                "R$ " + sb.valorPai.ToString("F2", CultureInfo.InvariantCulture),
                "Valor Total",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                
            );






        }

    }
}
