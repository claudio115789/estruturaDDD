using Domain.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
     public class Produto
    {
        public int Id { get; set; }
        public string NomeProduto { get; set; }
        public decimal Preco { get; set; }


        public Produto()
        {

        }

        public Produto(int id ,string nomeproduto, decimal preco)
        {
            this.Id = id;
            this.NomeProduto = nomeproduto;
            this.Preco = preco;
        }

        public void validarproduto()
        {
            var validacoes = new ValidRegraException<Produto>();
            if(string.IsNullOrEmpty(this.NomeProduto))
            {
                validacoes.AdicionarErroPara(x => x.NomeProduto, "O Nome do produto não foi informado");

            }
            if (NomeProduto.Length>150)
            {
                validacoes.AdicionarErroPara(x => x.NomeProduto, "O tamanho maximo do produto e de 150 caracteres");

            }
            if (this.Preco < 1)
            {
                validacoes.AdicionarErroPara(x => x.Preco, "O preço do produto nao foi informado");

            }
        }
    }
}
