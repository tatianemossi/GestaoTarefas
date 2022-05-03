using System;
using System.Collections.Generic;
using System.Linq;

namespace GestaoTarefas.WinApp
{
    public class RepositorioCompromisso : RepositorioBase<Compromisso>
    {
        public List<Compromisso> SelecionarTodosDoDia(DateTime data)
        {
            var dataInicial = new DateTime(data.Year, data.Month, data.Day, 0, 0, 0);
            var dataFinal = new DateTime(data.Year, data.Month, data.Day, 23, 59, 59);

            return registros.Where(x => x.Data >= dataInicial && x.Data <= dataFinal).ToList();
        }

        public List<Compromisso> SelecionarPassados()
        {
            return registros.Where(x => x.Data < DateTime.Now).ToList();
        }

        public List<Compromisso> SelecionarFuturos()
        {
            return registros.Where(x => x.HoraFinal >= DateTime.Now).ToList();
        }

        public List<Compromisso> SelecionarPeloNomeContato(string nome)
        {
            return registros.Where(x => x.Contato.Nome == nome).ToList();
        }

        public List<Compromisso> SelecionarFuturosIntervaloData(DateTime dataInicio, DateTime dataFinal)
        {
            var registrosFiltrados = registros.Where(x => x.HoraFinal >= dataInicio).ToList();
            return registrosFiltrados.Where(x => x.HoraInicio <= dataFinal).ToList();
        }
    }
}
