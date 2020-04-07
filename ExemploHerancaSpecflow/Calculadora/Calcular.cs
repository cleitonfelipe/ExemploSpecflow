using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    public class Calcular
    {
        public List<int> items { get; set; }
        public int Resultado { get; set; }

        public Calcular()
        {
            items = new List<int>();
            Resultado = 0;
        }

        public void Add(int valor) 
        {
            items.Add(valor);
        }

        public int somar() 
        {
            foreach (var item in items)
            {
                Resultado += item;
            }
            return Resultado;
        }
    }
}
