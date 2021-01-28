using System;
using System.Collections.Generic;
using System.Text;

namespace ListaTeste
{
    public class Itens
    {
        public string Nome { get; set; }

        public int Quantidade { get; set; }

        public int ValorUnitario { get; set; }

    
    public Itens()
    { }
    public Itens(string nome, int quantidade, int valorUnitario)
    {
        Nome = nome;
        Quantidade = quantidade;
        ValorUnitario = valorUnitario;
        

    }
}
}