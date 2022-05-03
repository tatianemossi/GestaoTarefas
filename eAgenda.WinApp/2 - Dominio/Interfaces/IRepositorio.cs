using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoTarefas.WinApp
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
