namespace GestaoTarefas.WinApp
{
    public class Tarefa
    {
        public int Numero;
        public string Titulo;

        public Tarefa()
        {
        }

        public Tarefa(int numero, string titulo)
        {
            Numero = numero;
            Titulo = titulo;
        }

        public override string ToString()
        {
            return $"Número: {Numero}, Título: {Titulo}";
        }
    }
}
