using System;
using System.Windows.Forms;

namespace GestaoTarefas.WinApp
{
    public partial class CadastroContatos : Form
    {
        private Contato contato;
        private readonly RepositorioContato repositorioContato = new RepositorioContato();

        public CadastroContatos()
        {
            InitializeComponent();
        }

        public Contato Contato
        {
            get { return contato; }
            set
            {
                contato = value;
                txtNome.Text = contato.Nome;
                txtEmail.Text = contato.Email;
                txtTelefone.Text = contato.Telefone;
                txtEmpresa.Text = contato.Empresa;
                txtCargo.Text = contato.Cargo;
            }
        }

        public void btnGravar_Click(object sender, EventArgs e)
        {
            if (ContatoEhValido())
            {
                contato.Nome = txtNome.Text;
                contato.Email = txtEmail.Text;
                contato.Telefone = txtTelefone.Text;
                contato.Empresa = txtEmpresa.Text;
                contato.Cargo = txtCargo.Text;

                DialogResult = DialogResult.OK;
            }
            else
            {
                DialogResult = DialogResult.None;
            }
        }

        private bool ContatoEhValido()
        {
            if (repositorioContato.NomeJaExiste(txtNome.Text) || txtNome.Text == "")
            {
                MessageBox.Show("Não é possível inserir, pois o nome do contato já existe ou está vazio.",
                    "Adicionando Contato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (repositorioContato.EmailJaExiste(txtEmail.Text) || txtEmail.Text == "")
            {
                MessageBox.Show("Não é possível inserir, pois o email do contato já existe ou está vazio.",
                    "Adicionando Contato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (repositorioContato.TelefoneJaExiste(txtTelefone.Text) || txtTelefone.Text == "")
            {
                MessageBox.Show("Não é possível inserir, pois o telefone do contato já existe ou está vazio.",
                    "Adicionando Contato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false; 
            }

            if (!contato.EmailEhValido(txtEmail.Text))
            {
                MessageBox.Show("Email inválido.",
                    "Adicionando Contato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (!contato.TelefoneEhValido(txtTelefone.Text))
            {
                MessageBox.Show("Telefone inválido.",
                    "Adicionando Contato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }
    }
}
