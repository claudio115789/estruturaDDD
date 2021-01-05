using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Generic
{
    public interface InterfaceGeneric<T> where T : class
    {
        void Adicionar(T Objeto);
        void Atualizar(T Objeto);
        void Deletar(int Id);
        T Obter(int Id);
        List<T> ListarTodos();

    }
}
