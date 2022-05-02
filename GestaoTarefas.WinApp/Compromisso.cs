using System;

namespace GestaoTarefas.WinApp
{
    public class Compromisso : EntidadeBase
    {
        public string Assunto { get; set; }
        public string Local { get; set; }
        public DateTime Data { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraFinal { get; set; }
        public Contato Contato { get; set; }

        public override string ToString()
        {
            return $"Assunto: {Assunto} - Local: {Local} - Data: {Data} - Horário de Início: {HoraInicio} - " +
                $"Horário Final: {HoraFinal} - Contato {Contato}";
        }
    }
}
