using System.Collections.Generic;
using System;
namespace ListaTeste
{
    public class Cliente
    {
        public string Email { get; set; }
        public List<Itens> Itens { get; set; } 
   
        public Cliente(string email, List<Itens> itens)
        {
          
            Email = email;
            Itens = itens;
        }



    }
    }