using System.Text.RegularExpressions;

namespace eAgenda.Dominio.Entidades
{
    public class Contato : EntidadeBase
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Empresa { get; set; }
        public string Cargo { get; set; }

        public override string ToString()
        {
            return $"Nome: {Nome} - Email: {Email} - Empresa: {Empresa} - Cargo: {Cargo}";
        }

        public bool EmailEhValido(string email)
        {
            Regex rg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+))@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+))\.([A-Za-z]{2,})$");

            if (rg.IsMatch(email))
                return true;

            return false;
        }

        public bool TelefoneEhValido(string telefone)
        {
            Regex rg = new Regex(@"^\(?[1-9]{2}\)? ?(?:[2-8]|9[1-9])[0-9]{3}\-?[0-9]{4}$");

            if (rg.IsMatch(telefone))
                return true;

            return false;
        }
    }
}