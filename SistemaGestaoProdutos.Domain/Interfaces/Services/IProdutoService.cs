using SistemaGestaoProdutos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestaoProdutos.Domain.Interfaces.Services
{
    public interface IProdutoService
    {
        Produto GetProduto(int codigo);

        IEnumerable<Produto> GetAll();
        Produto Add(Produto produto);
        Produto Delete(int codigo);
        Produto Update(Produto produto);
    }
}
