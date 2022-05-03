﻿using eAgenda.Dominio.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace eAgenda.Dominio.Entidades
{
    public class Tarefa : EntidadeBase
    {
        private List<ItemTarefa> itens = new List<ItemTarefa>();

        public Tarefa()
        {
            DataCriacao = DateTime.Now;
        }

        public Tarefa(int n, string t) : this()
        {
            Numero = n;
            Titulo = t;
            DataConclusao = null;
        }

        public int Numero { get; set; }
        public string Titulo { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataConclusao { get; set; }
        public PrioridadeEnum Prioridade { get; set; }

        [JsonPropertyName("Itens")]
        public List<ItemTarefa> Itens { get { return itens; } set { itens = value; } }

        public override string ToString()
        {
            var percentual = CalcularPercentualConcluido();

            if (DataConclusao.HasValue)
            {
                return $"Número: {Numero} - Título: {Titulo} - " +
                    $"Percentual: {percentual} - " +
                    $"Prioridade: {Prioridade} - " +
                    $"Concluída: {DataConclusao.Value.ToShortDateString()}";
            }

            return $"Número: {Numero} - Título: {Titulo} - Prioridade: {Prioridade} - Percentual: {percentual}%";
        }

        public void AdicionarItem(ItemTarefa item)
        {
            if (Itens.Exists(x => x.Equals(item)) == false)
                itens.Add(item);
        }

        public void ConcluirItem(ItemTarefa item)
        {
            ItemTarefa itemTarefa = itens.Find(x => x.Equals(item));

            itemTarefa?.Concluir();

            var percentual = CalcularPercentualConcluido();
            if (percentual == 100)
                DataConclusao = DateTime.Now;
        }

        public void MarcarPendente(ItemTarefa item)
        {
            ItemTarefa itemTarefa = itens.Find(x => x.Equals(item));
            itemTarefa?.MarcarPendente();
        }

        public decimal CalcularPercentualConcluido()
        {
            if (itens.Count == 0)
                return 0;

            int qtdConcluidas = itens.Count(x => x.Concluido);

            var percentualConcluido = qtdConcluidas / (decimal)itens.Count() * 100;

            return Math.Round(percentualConcluido, 2);
        }
    }
}
