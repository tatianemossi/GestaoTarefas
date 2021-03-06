using eAgenda.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace eAgenda.Repositorio
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
            return registros.Where(x => x.HoraFinal < DateTime.Now).ToList();
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

        public void AtualizarCompromisso(string nomeAntigo, string nomeNovo)
        {
            foreach (var compromisso in registros)
            {
                if (compromisso != null)
                {
                    if (compromisso.Contato.Nome == nomeAntigo)
                    {
                        compromisso.Contato.Nome = nomeNovo;
                    }
                }
            }
        }
    }
}
