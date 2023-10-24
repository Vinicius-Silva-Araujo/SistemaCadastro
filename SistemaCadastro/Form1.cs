namespace SistemaCadastro
{
    public partial class Form1 : Form
    {
        List<Pessoa> pessoa;
        public Form1()
        {
            InitializeComponent();

            pessoa = new List<Pessoa>();

            comboEstCivil.Items.Add("Casado");

            comboEstCivil.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonCasdastre_Click(object sender, EventArgs e)
        {

        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {

        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {

        }
        private void Listar()
        {
            lista.Items.Clear();
            foreach (Pessoa p  in pessoa)
            {
                lista.Items.Add (p.Nome);
            }
        }
    }
}