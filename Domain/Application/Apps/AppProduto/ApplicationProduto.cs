using Application.Interfaces.InterfaceGeneric;
using Domain.Entities;
using Domain.Interface.InterfaceProduto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Apps.AppProduto
{
    public class ApplicationProduto : IApplicationGeneric<Produto>
    {
        IProdutoRepository Repository;

        public ApplicationProduto(IProdutoRepository _IprodutoRepository)
        {

            Repository = _IprodutoRepository;
        }

        public void Adicionar(Produto Objeto)
        {
            Repository.Adicionar(Objeto);
        }

        public void Atualizar(Produto Objeto)
        {
            Repository.Atualizar(Objeto);
        }

        public void Deletar(int Id)
        {
            Repository.Deletar(Id);
        }

        public List<Produto> ListarTodos()
        {
            return Repository.ListarTodos();
        }

        public Produto Obter(int Id)
        {
            return Repository.Obter(Id);
        }
    }
}
