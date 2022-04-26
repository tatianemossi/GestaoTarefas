﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GestaoTarefas.WinApp
{
    public partial class ListagemTarefas : Form
    {
        private RepositorioTarefa repositorioTarefa;

        public ListagemTarefas()
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

        private void btnInserir_Click(object sender, EventArgs e)
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Tarefa tarefaSelecionada = (Tarefa)listTarefas.SelectedItem;

            if (tarefaSelecionada == null)
            {
                MessageBox.Show("Favor selecionar uma tarefa", 
                    "Edição de tarefas", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Exclamation);
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

        private void btnExcluir_Click(object sender, EventArgs e)
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
    }
}