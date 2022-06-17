using SistemaGestaoProdutos.Domain.Entities;
using SistemaGestaoProdutos.Domain.Interfaces.Repositories;
using SistemaGestaoProdutos.Infra.Data.EFCore.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestaoProdutos.Infra.Data.EFCore.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        public readonly AppEFCoreDbCpntext context;

        public ProdutoRepository(AppEFCoreDbCpntext context)
        {
            this.context = context;
        }

        public Produto Add(Produto produto)
        {
            context.Produtos.Add(produto);
            context.SaveChanges();
            return produto;
        }

        public Produto Delete(int codigo)
        {
            Produto produto = context.Produtos.Find(codigo);
            context.Produtos.Remove(produto);
            context.SaveChanges();
            return produto;
        }

        public IEnumerable<Produto> GetAll()
        {
            return context.Produtos;
        }

        public Produto GetProduto(int codigo)
        {
            Produto produto = context.Produtos.Find(codigo);
            return produto;
        }

        public Produto Update(Produto produto)
        {
            context.Produtos.Update(produto);
            context.SaveChanges();
            return produto;
        }
    }
}
