using System;
using System.Collections.Generic;
using System.Linq;

namespace ListaTeste
{
    public class ClienteService
    {
        public List<Cliente> AdicionaClienteEmLista(List<Cliente> listaClientes)
        {
            var itemService = new ItemService();
            Console.WriteLine("Digite o seu e-mail: ");
            var emailUsuario = Console.ReadLine();
            Console.WriteLine(emailUsuario);

            var novoCliente = new Cliente(emailUsuario, new List<Itens>());

            if (!VerificarSeClienteExiste(novoCliente.Email, listaClientes)){
                novoCliente.Itens = itemService.CadastrarItens(novoCliente.Itens);
                novoCliente.Itens = itemService.CadastrarItens(novoCliente.Itens); //adicionar mais um item na lista
                listaClientes.Add(novoCliente);
            }
            
            return listaClientes;
        }

        public bool VerificarSeClienteExiste(string emailCliente, List<Cliente> listaCliente){
            var retorno = listaCliente.Any(x => x.Email == emailCliente);

            return retorno;
        }
    }
}