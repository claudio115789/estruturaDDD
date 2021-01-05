using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Mapping
{
     public class ProdutoMap : EntityTypeConfiguration<Produto>

    {
        public ProdutoMap()
        {
            HasKey(t => t.Id);
            Property(t => t.NomeProduto).HasMaxLength(150);
            Property(t => t.Preco);

        }
    }
}
