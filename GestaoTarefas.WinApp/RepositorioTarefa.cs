using System;
using System.Collections.Generic;
using System.Linq;

namespace GestaoTarefas.WinApp
{
    public class RepositorioTarefa
    {
        List<Tarefa> tarefas = new List<Tarefa>();

        private int contador = 0;

        public List<Tarefa> SelecionarTodos()
        {
            return tarefas;
        }

        public void Inserir(Tarefa novaTarefa)
        {
            novaTarefa.Numero = ++contador;
            tarefas.Add(novaTarefa);
        }

        public void Editar(Tarefa tarefa)
        {
            var tarefaEditar = tarefas.FirstOrDefault(x => x.Numero == tarefa.Numero);
            tarefaEditar.Titulo = tarefa.Titulo;
        }

        public void Excluir(Tarefa tarefa)
        {
            tarefas.Remove(tarefa);
        }
    }
}
