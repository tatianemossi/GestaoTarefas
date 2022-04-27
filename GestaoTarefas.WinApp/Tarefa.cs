using System;

namespace GestaoTarefas.WinApp
{
    public class Tarefa
    {
        public int Numero;
        public string Titulo;
        public DateTime DataCriacao;

        public Tarefa()
        {
        }

        public Tarefa(int numero, string titulo)
        {
            Numero = numero;
            Titulo = titulo;
            DataCriacao = DateTime.Now;
        }

        public override string ToString()
        {
            return $"Número: {Numero} - Título: {Titulo} - Data de Criação: {DataCriacao}";
        }
    }
}
