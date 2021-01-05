using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.InterfaceGeneric
{
   public  interface IApplicationGeneric<T>where T : class
    {
        void Adicionar(T objeto);
        void Atualizar(T objeto);
        void Deletar(int Id);
        T Obter(int Id);
        List<T> ListarTodos();
    }
}
