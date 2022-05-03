using System;
using System.Collections.Generic;

namespace eAgenda.Utilitario
{
    public static class ConversorEnum
    {
        public static IList<T> EnumToList<T>()
        {
            IList<T> lista = new List<T>();
            Type tipo = typeof(T);
            if (tipo != null)
            {
                Array valoresEnum = Enum.GetValues(tipo);
                foreach (T valor in valoresEnum)
                {
                    lista.Add(valor);
                }
            }

            return lista;
        }
    }
}
