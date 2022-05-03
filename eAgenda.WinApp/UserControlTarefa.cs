using eAgenda.Dominio.Entidades;
using eAgenda.Repositorio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace eAgenda.WinApp
{
    public partial class UserControlTarefa : UserControl
    {
        private RepositorioTarefa repositorioTarefa;

        public UserControlTarefa()
        {
            repositorioTarefa = new RepositorioTarefa();
            InitializeComponent();
            CarregarTarefas();
        }

        private void CarregarTarefas()
        {
            List<Tarefa> tarefas = repositorioTarefa.SelecionarTodos();

            listTarefas.Items.Clear();

            foreach (Tarefa tarefa in tarefas)
            {
                listTarefas.Items.Add(tarefa);
            }
        }

        private void btnInserirTarefa_Click(object sender, EventArgs e)
        {
            CadastroTarefas tela = new CadastroTarefas();

            tela.Tarefa = new Tarefa();

            var resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                repositorioTarefa.Inserir(tela.Tarefa);
                CarregarTarefas();
            }
        }

        private void btnEditarTarefa_Click(object sender, EventArgs e)
        {
            Tarefa tarefaSelecionada = (Tarefa)listTarefas.SelectedItem;

            if (tarefaSelecionada == null)
            {
                MessageBox.Show("Favor selecionar uma tarefa",
                    "Edição de tarefas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                CadastroTarefas tela = new CadastroTarefas();

                tela.Tarefa = tarefaSelecionada;

                var resultado = tela.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    repositorioTarefa.Editar(tela.Tarefa);
                    CarregarTarefas();
                }
            }
        }

        private void btnExcluirTarefa_Click(object sender, EventArgs e)
        {
            Tarefa tarefaSelecionada = (Tarefa)listTarefas.SelectedItem;

            if (tarefaSelecionada == null)
            {
                MessageBox.Show("Favor selecionar uma tarefa",
                    "Exclusão de tarefas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                DialogResult resultado = MessageBox.Show("Deseja realmente excluir a tarefa?",
                "Exclusão de tarefas",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);

                if (resultado == DialogResult.OK)
                {
                    repositorioTarefa.Excluir(tarefaSelecionada);
                    CarregarTarefas();
                }
            }
        }

        private void btnCadastrarItens_Click(object sender, System.EventArgs e)
        {
            Tarefa tarefaSelecionada = (Tarefa)listTarefas.SelectedItem;

            if (tarefaSelecionada == null)
            {
                MessageBox.Show("Favor selecionar uma tarefa",
                    "Edição de tarefas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            CadastroItensTarefa tela = new CadastroItensTarefa(tarefaSelecionada);

            if (tela.ShowDialog() == DialogResult.OK)
            {
                List<ItemTarefa> itens = tela.ItensAdicionados;

                repositorioTarefa.AdicionarItens(tarefaSelecionada, itens);

                CarregarTarefas();
            }
        }

        private void btnAtualizarItens_Click(object sender, EventArgs e)
        {
            Tarefa tarefaSelecionada = (Tarefa)listTarefas.SelectedItem;

            if (tarefaSelecionada == null)
            {
                MessageBox.Show("Favor selecionar uma tarefa",
                    "Edição de tarefas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            AtualizacaoItensTarefa tela = new AtualizacaoItensTarefa(tarefaSelecionada);

            if (tela.ShowDialog() == DialogResult.OK)
            {
                List<ItemTarefa> itensConcluidos = tela.ItensConcluidos;

                List<ItemTarefa> itensPendentes = tela.ItensPendentes;

                repositorioTarefa.AtualizarItens(tarefaSelecionada, itensConcluidos, itensPendentes);
            }

            CarregarTarefas();
        }

        public void btnVisualizarPendentes_Click(object sender, EventArgs e)
        {
            List<Tarefa> tarefas = repositorioTarefa.SelecionarPendentes();

            listTarefas.Items.Clear();

            foreach (Tarefa tarefa in tarefas)
            {
                listTarefas.Items.Add(tarefa);
            }
        }

        public void btnVisualizarConcluidas_Click(object sender, EventArgs e)
        {
            List<Tarefa> tarefas = repositorioTarefa.SelecionarConcluidas();

            listTarefas.Items.Clear();

            foreach (Tarefa tarefa in tarefas)
            {
                listTarefas.Items.Add(tarefa);
            }
        }
    }
}
