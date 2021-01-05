using Domain.Entities;
using Domain.Interface.InterfaceProduto;
using Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.RepositoryProduto
{
     public class ProdutoRepository : RepositoryGeneric<Produto>,IProdutoRepository
    {
    }
}
