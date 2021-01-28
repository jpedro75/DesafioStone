using System;
using System.Collections.Generic;
using System.Text;

namespace ListaTeste
{
    public class ItemService
    {
        public List<Itens> CadastrarItens(List<Itens> listaItens){
            var novoItem = new Itens();
            ConsoleKeyInfo resposta;
                    
            do
            {
                Console.WriteLine("Digite o nome do item");
                novoItem.Nome = Console.ReadLine();

                Console.WriteLine("Digite a quantidade do item");
                novoItem.Quantidade = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite o valor unitário do item");
                novoItem.ValorUnitario = Convert.ToInt32(Console.ReadLine());

                listaItens.Add(novoItem);
                Console.WriteLine("Deseja adicionar um novo item?");
                resposta = Console.ReadKey();//S ou s
                   
            }while (resposta.ToString().ToLower() !="s");

                return listaItens;
        }
        
        
        
    }
}

        // public string Nome { get; set; }

        // public int Quantidade { get; set; }

        // public int ValorUnitario { get; set; }
        //READLINE Só retorna STRING "157"
