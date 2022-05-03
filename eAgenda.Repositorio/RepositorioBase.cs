using eAgenda.Dominio.Entidades;
using eAgenda.Dominio.Interfaces;
using eAgenda.Utilitario;
using System.Collections.Generic;
using System.Linq;

namespace eAgenda.Repositorio
{
    public class RepositorioBase<T> : IRepositorio<T> where T : EntidadeBase
    {
        protected readonly List<T> registros;

        public RepositorioBase()
        {
            registros = GerenciadorBackup<T>.CarregarDados();
        }

        public void Inserir(T entidade)
        {
            entidade.Id = BuscarUltimoIdDisponivel(); ;
            registros.Add(entidade);

            SalvarDados();
        }

        public void Editar(T entidade)
        {
            var entidadeEditar = registros.FirstOrDefault(x => x.Id == entidade.Id);
            entidadeEditar = entidade;

            SalvarDados();
        }

        public void Excluir(T entidade)
        {
            registros.Remove(entidade);

            SalvarDados();
        }

        public List<T> SelecionarTodos()
        {
            return registros;
        }

        public int BuscarUltimoIdDisponivel()
        {
            var id = registros.OrderBy(x => x.Id).Select(x => x.Id).LastOrDefault();

            return id + 1;
        }

        public void SalvarDados()
        {
            GerenciadorBackup<T>.SalvarDados(registros);
        }
    }
}
