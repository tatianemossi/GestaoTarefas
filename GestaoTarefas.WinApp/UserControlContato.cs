using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GestaoTarefas.WinApp
{
    public partial class UserControlContato : UserControl
    {
        private RepositorioContato repositorioContato;
        private RepositorioCompromisso repositorioCompromisso;

        public UserControlContato()
        {
            repositorioContato = new RepositorioContato();
            repositorioCompromisso = new RepositorioCompromisso();
            InitializeComponent();
            CarregarContatos();
        }

        private void CarregarContatos()
        {
            List<Contato> contatos = repositorioContato.SelecionarTodos();

            listContatos.Items.Clear();

            foreach (Contato contato in contatos)
            {
                listContatos.Items.Add(contato);
            }
        }

        private void btnInserirContato_Click(object sender, EventArgs e)
        {
            listContatos.Visible = true;
            tvwContatosOrdenados.Visible = false;

            CadastroContatos tela = new CadastroContatos();

            tela.Contato = new Contato();

            var resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                repositorioContato.Inserir(tela.Contato);
                CarregarContatos();
            }
        }

        private void btnEditarContato_Click(object sender, EventArgs e)
        {
            listContatos.Visible = true;
            tvwContatosOrdenados.Visible = false;

            Contato contatoSelecionado = (Contato)listContatos.SelectedItem;

            if (contatoSelecionado == null)
            {
                MessageBox.Show("Favor selecionar um contato",
                    "Edição de contatos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                CadastroContatos tela = new CadastroContatos();

                tela.Contato = contatoSelecionado;

                var resultado = tela.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    repositorioContato.Editar(tela.Contato);
                    CarregarContatos();
                }
            }
        }

        private void btnExcluirContato_Click(object sender, EventArgs e)
        {
            listContatos.Visible = true;
            tvwContatosOrdenados.Visible = false;

            Contato contatoSelecionado = (Contato)listContatos.SelectedItem;

            var listaCompromissosComContato = repositorioCompromisso.SelecionarPeloNomeContato(contatoSelecionado.Nome);

            if (listaCompromissosComContato.Any(x => x.HoraFinal > DateTime.Now))
            {
                MessageBox.Show("Não é possível excluir, pois o contato está relacionado a um compromisso",
                    "Exclusão de contatos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            if (contatoSelecionado == null)
            {
                MessageBox.Show("Favor selecionar um contato",
                    "Exclusão de contatos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                DialogResult resultado = MessageBox.Show("Deseja realmente excluir o contato?",
                    "Exclusão de contatos",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);

                if (resultado == DialogResult.OK)
                {
                    repositorioContato.Excluir(contatoSelecionado);
                    CarregarContatos();
                }
            }
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            listContatos.Visible = false;
            tvwContatosOrdenados.Visible = true;

            List<Contato> contatos = repositorioContato.SelecionarTodos();

            contatos = contatos.OrderBy(x => x.Cargo).ToList();

            var cargoAgrupador = "";

            TreeNode nodeCargo = null;

            foreach (var contato in contatos)
            {
                if (contato.Cargo != cargoAgrupador)
                {
                    if (nodeCargo != null)
                        tvwContatosOrdenados.Nodes.Add(nodeCargo);

                    nodeCargo = new TreeNode(contato.Cargo);

                    cargoAgrupador = contato.Cargo;
                }

                var nodeContato = new TreeNode(contato.Nome);
                nodeCargo.Nodes.Add(nodeContato);

            }

            if (nodeCargo == null)
                tvwContatosOrdenados.Nodes.Add(new TreeNode("Não existem contatos."));
        }
    }
}
