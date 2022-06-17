using SistemaGestaoProdutos.Domain.Entities;
using SistemaGestaoProdutos.Domain.Interfaces.Repositories;
using SistemaGestaoProdutos.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestaoProdutos.Domain.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _ProdutoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
        {
            this._ProdutoRepository = produtoRepository;
        }

        public Produto Add(Produto produto)
        {
            return _ProdutoRepository.Add(produto);

        }

        public Produto Delete(int id)
        {
            return _ProdutoRepository.Delete(id);
        }

        public IEnumerable<Produto> GetAll()
        {
            return _ProdutoRepository.GetAll();
        }

        public Produto GetProduto(int id)
        {
            return _ProdutoRepository.GetProduto(id);
        }

        public Produto Update(Produto produto)
        {
            return _ProdutoRepository.Update(produto);
        }


    }
}
