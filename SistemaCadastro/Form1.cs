using System.Diagnostics.Eventing.Reader;

namespace SistemaCadastro
{
    public partial class Form1 : Form
    {
        List<Pessoa> pessoas;
        public Form1()
        {
            InitializeComponent();

            pessoas = new List<Pessoa>();

            comboEstCivil.Items.Add("Casado");
            comboEstCivil.Items.Add("Solteiro");
            comboEstCivil.Items.Add("Viuvo");
            comboEstCivil.Items.Add("Divorciado");

            comboEstCivil.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonCasdastre_Click(object sender, EventArgs e)
        {
            int index = -1;
            foreach (Pessoa pessoa in pessoas)
            {
                if (pessoa.Nome == TxtNome.Text)
                {
                    index = pessoas.IndexOf(pessoa);
                }
            }
            if (TxtNome.Text == "")
            {
                MessageBox.Show("Preencha o campo nome. ");
                TxtNome.Focus();
                return;
            }
            if (TxtEmail.Text == "")
            {
                MessageBox.Show("Preencha o campo Email. ");
                txtTelefone.Focus();
                return;

            }
            if (txtTelefone.Text == "(  )      -")
            {
                MessageBox.Show("Preencha o campo Telefone. ");
                txtTelefone.Focus();
                return;

            }

            char sexo;

            if (radioM.Checked)
            {
                sexo = 'M';
            }
            else if (radioF.Checked)
            {
                sexo = 'F';
            }
            else
            {
                sexo = 'O';
            }

            Pessoa p = new Pessoa();
            p.Nome = TxtNome.Text;
            p.Email = TxtEmail.Text;
            p.DataNascimento = txtDataNascimento.Text;
            p.EstadoCivil = comboEstCivil.SelectedItem.ToString();
            p.Telefone = txtTelefone.Text;
            p.CasaPropira = CheckCasa.Checked;
            p.Veiculo = checkVeiculo.Checked;
            p.Sexo = sexo;

            if (index < 0)
            {
                pessoas.Add(p);
            }
            else
            {
                pessoas[index] = p;
            }

            buttonLimpar_Click(buttonLimpar, EventArgs.Empty);

            Listar();

        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            int indice = lista.SelectedIndex;
            pessoas.RemoveAt(indice);
            Listar();

        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            TxtNome.Text = "";
            TxtEmail.Text = "";
            txtDataNascimento.Text = "";
            comboEstCivil.SelectedIndex = 0;
            txtTelefone.Text = "";
            CheckCasa.Checked = false;
            checkVeiculo.Checked = false;
            radioM.Checked = true;
            radioF.Checked = false;
            radioO.Checked = false;
            TxtNome.Focus();

        }
        private void Listar()
        {
            lista.Items.Clear();
            foreach (Pessoa p in pessoas)
            {
                lista.Items.Add(p.Nome);
            }
        }

        private void lista_DoubleClick(object sender, EventArgs e)
        {
            int indice = lista.SelectedIndex;
            Pessoa p = pessoas[indice];
            TxtNome.Text = p.Nome;
            TxtEmail.Text = p.Email;
            txtDataNascimento.Text = p.DataNascimento;
            comboEstCivil.SelectedItem = p.EstadoCivil;
            txtTelefone.Text = p.Telefone;
            CheckCasa.Checked = p.Veiculo;


            switch (p.Sexo)
            {
                case 'M':
                    radioM.Checked = true;
                    break;
                case 'F':
                    radioF.Checked = true;
                    break;
                default:
                    radioO.Checked = true;
                    break;
            }

        }
    }
}