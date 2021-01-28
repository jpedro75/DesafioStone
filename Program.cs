using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaTeste
{
    public class ClienteFinal {

        static void Main(string[] args)
        {
            ClienteService clienteService = new ClienteService();
            var listaClientes = new List<Cliente>();

            //Opção - Adicionar Usuário1
            listaClientes = clienteService.AdicionaClienteEmLista(listaClientes);

            foreach(var x in listaClientes){
                Console.WriteLine("Existe na lista de itens: " + x.Email);
                int index = 1;
                foreach(var item in x.Itens){
                    Console.WriteLine("Item " + index);
                    Console.WriteLine("Nome: " + item.Nome);
                    Console.WriteLine("Quantidade: " + item.Quantidade);
                    Console.WriteLine("Valor unitário do item:" + item.ValorUnitario);
                    index++;
                }
                    var valor = x.Itens.Sum(y => y.Quantidade * y.ValorUnitario);
                    Console.WriteLine("Valor total é: " + valor);
            }


            //Opção - 
            //LISTACLIENTES == LIST<CLIENTE>(); 
            // ADICIONARCLIENTEMLISTA retornava sempre uma string/  LIST<CLIENTE>();  = string
          
          
        }
    }
    
//TODOLIST
// Ler e-mail cliente
// Adicionar Lista de Itens com qtd e valor unitário
// 


            /*1List<Cliente> listaClientes = new List<Cliente>();
            Cliente cliente1 = new Cliente();
            cliente1.Email = "joao.pedro.mazarim@gmail.com";
            cliente1.Quantidade = 10;
            cliente1.ValorUnitario = 2000;
            listaClientes.Add(cliente1);
            foreach (Cliente cliente in listaClientes)
            {
                Console.WriteLine(cliente.Email);
            }*/

        }
    




       

