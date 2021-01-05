using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Validations
{
   public  class ValidRegraException<T>: ValidException

    {
        internal void AdicionarErroPara<TPropriedade>(Expression<Func<T,TPropriedade>>propriedade, string mensagem)

        {
            _Erros.Add(new ViolacaoValid { Propriedade = propriedade, Mensagem = mensagem });
        }
    }
}
