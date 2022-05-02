using System.Linq;

namespace GestaoTarefas.WinApp
{
    public class RepositorioContato : RepositorioBase<Contato>
    {
        public bool NomeJaExiste(string nome)
        {
            return registros.Any(x => x.Nome.ToLower() == nome.ToLower());
        }

        public bool EmailJaExiste(string email)
        {
            return registros.Any(x => x.Email.ToLower() == email.ToLower());
        }

        public bool TelefoneJaExiste(string telefone)
        {
            return registros.Any(x => x.Telefone == telefone);
        }
    }
}
