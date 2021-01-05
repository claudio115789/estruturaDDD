using Domain.Entities;
using Infrastructure.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Config
{
    public  class ContextBase : DbContext
    {
        public ContextBase() : base("ConnectionString")
        {


        }

        protected override void OnModelCreating(DbModelBuilder modelBluilder)
        {
            base.OnModelCreating(modelBluilder);
            modelBluilder.Configurations.Add(new ProdutoMap());
        }

        public DbSet<Produto> ObjetoProduto { get; set; }
    }
}
