using eAgenda.Dominio.Entidades;
using System.Collections.Generic;

namespace eAgenda.Dominio.Interfaces
{
    public interface IRepositorio<T> where T : EntidadeBase
    {
        void Inserir(T entidade);
        void Editar(T entidade);
        void Excluir(T entidade);
        List<T> SelecionarTodos();
        void SalvarDados();
        int BuscarUltimoIdDisponivel();
    }
}
