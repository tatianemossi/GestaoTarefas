using eAgenda.Dominio.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace eAgenda.Repositorio
{
    public class RepositorioTarefa : RepositorioBase<Tarefa>
    {
        public void AdicionarItens(Tarefa tarefaSelecionada, List<ItemTarefa> itens)
        {
            foreach (var item in itens)
            {
                tarefaSelecionada.AdicionarItem(item);
            }

            SalvarDados();
        }

        public void AtualizarItens(Tarefa tarefaSelecionada,
            List<ItemTarefa> itensConcluidos, List<ItemTarefa> itensPendentes)
        {
            foreach (var item in itensConcluidos)
            {
                tarefaSelecionada.ConcluirItem(item);
            }

            foreach (var item in itensPendentes)
            {
                tarefaSelecionada.MarcarPendente(item);
            }

            SalvarDados();
        }

        public bool TarefaJaExiste(string text)
        {
            return registros.Any(x => x.Titulo.ToLower() == text.ToLower());
        }

        public List<Tarefa> SelecionarPendentes()
        {
            return registros.Where(x => x.DataConclusao == null)
                .OrderBy(x => x.Prioridade)
                .ToList();
        }

        public List<Tarefa> SelecionarConcluidas()
        {
            return registros.Where(x => x.DataConclusao != null)
                .OrderBy(x => x.Prioridade)
                .ToList();
        }
    }
}
