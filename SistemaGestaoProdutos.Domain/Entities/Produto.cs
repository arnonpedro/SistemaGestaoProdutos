using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestaoProdutos.Domain.Entities
{
    public class Produto
    {
        //• Código do produto(sequencial e não nulo)
        [Key]
        public int Codigo { get; set; }
        //• Descrição do produto(não nulo)
        public string Descricao { get; set; }
        //• Situação do produto(Ativo ou Inativo)
        public string Situacao { get; set; }
        //• Data de fabricação
        public DateTime DataFabricacao { get; set; }
        //• Data de validade
        public DateTime DataValidade { get; set; }
        //• Código do fornecedor
        public int CodigoFornecedor { get; set; }
        //• Descrição do fornecedor
        public String DescricaoFornecedor { get; set; }
        //• CNPJ do fornecedor
        public String CnpjFornecedor { get; set; }
    }
}
