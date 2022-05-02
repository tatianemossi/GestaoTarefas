using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GestaoTarefas.WinApp
{
    public partial class UserControlCompromisso : UserControl
    {
        private RepositorioCompromisso repositorioCompromisso;

        public UserControlCompromisso()
        {
            repositorioCompromisso = new RepositorioCompromisso();
            InitializeComponent();
            CarregarCompromissos();
        }

        private void CarregarCompromissos()
        {
            List<Compromisso> compromissos = repositorioCompromisso.SelecionarTodos();

            listCompromissos.Items.Clear();

            foreach (Compromisso compromisso in compromissos)
            {
                listCompromissos.Items.Add(compromisso);
            } 
        }

        private void btnInserirCompromisso_Click(object sender, EventArgs e)
        { 
            CadastroCompromissos tela = new CadastroCompromissos();

            tela.Compromisso = new Compromisso();

            var resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                repositorioCompromisso.Inserir(tela.Compromisso);
                CarregarCompromissos();
            }
        }

        private void btnEditarCompromisso_Click(object sender, EventArgs e)
        {
            Compromisso compromissoSelecionado = (Compromisso)listCompromissos.SelectedItem;

            if (compromissoSelecionado == null)
            {
                MessageBox.Show("Favor selecionar um compromisso",
                    "Edição de compromissos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                CadastroCompromissos tela = new CadastroCompromissos();

                tela.Compromisso = compromissoSelecionado;

                var resultado = tela.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    repositorioCompromisso.Editar(tela.Compromisso);
                    CarregarCompromissos();
                }
            }
        }

        private void btnExcluirCompromisso_Click(object sender, EventArgs e)
        {
            Compromisso compromissoSelecionado = (Compromisso)listCompromissos.SelectedItem;

            if (compromissoSelecionado == null)
            {
                MessageBox.Show("Favor selecionar um compromisso",
                    "Exclusão de compromissos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                DialogResult resultado = MessageBox.Show("Deseja realmente excluir o compromisso?",
                "Exclusão de compromissos",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);

                if (resultado == DialogResult.OK)
                {
                    repositorioCompromisso.Excluir(compromissoSelecionado);
                    CarregarCompromissos();
                }
            }
        }

        private void btnVisualizarCompromissos_Click(object sender, EventArgs e)
        {

        }

        private void btnVisualizarFuturos_Click(object sender, EventArgs e)
        {

        }
    }
}
