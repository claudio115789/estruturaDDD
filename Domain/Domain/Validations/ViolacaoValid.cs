using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Validations
{
    public class ViolacaoValid
    {
        public LambdaExpression Propriedade { get; set; }

        public string Mensagem { get; set; }
    }
}
