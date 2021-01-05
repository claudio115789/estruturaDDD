using Domain.Generic;
using Infrastructure.Config;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class RepositoryGeneric<T> : InterfaceGeneric<T>, IDisposable where T : class
    {
        private readonly ContextBase Contexto;

        public RepositoryGeneric()
        {
            Contexto = new ContextBase();
        }

       
        ~RepositoryGeneric()
        {
            Dispose(false);
        }
        public void Adicionar(T Objeto)
        {
            Contexto.Set<T>().Add(Objeto);
            Contexto.SaveChanges();
        }

        public void Atualizar(T Objeto)
        {
            Contexto.Entry(Objeto).State = EntityState.Modified;
            Contexto.SaveChanges();
        }

        public void Deletar(int Id)
        {
            var ObjetoRetorno = Contexto.Set<T>().Find(Id);

            if (ObjetoRetorno != null)

                Contexto.Set<T>().Remove(ObjetoRetorno);
            Contexto.SaveChanges(); 
        }

       

        public List<T> ListarTodos()
        {
            return Contexto.Set<T>().ToList();
        }

        public T Obter(int Id)
        {
            return Contexto.Set<T>().Find(Id);
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        public virtual void Dispose(bool valor)
        {
            if (!valor) return;

            if (Contexto == null) return;
            Contexto.Dispose();
        }
    }
}
