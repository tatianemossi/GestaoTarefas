using System;

namespace eAgenda.Dominio.Entidades
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
            return $"Assunto: {Assunto} - Contato: {Contato?.Nome} - Local: {Local} - Data: {Data.ToString("dd/MM/yyyyy")} - Horário de Início: {HoraInicio.ToString("HH:mm:ss")} - " +
                $"Horário Final: {HoraFinal.ToString("HH:mm:ss")}";
        }
    }
}
