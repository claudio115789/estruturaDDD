using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Validations
{
   public class ValidException: Exception
    {
        public  IList<ViolacaoValid> _Erros = new List<ViolacaoValid>();
        public readonly Expression<Func<object, object>> _objeto = x => x;


        protected void AdicionarMensagemErro(string Mensagem)
        {
            _Erros.Add(new ViolacaoValid { Propriedade = _objeto, Mensagem = Mensagem });
        }
    }
}
