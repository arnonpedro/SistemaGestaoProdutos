using Microsoft.AspNetCore.Mvc;
using SistemaGestaoProdutos.Domain.Entities;
using SistemaGestaoProdutos.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaGestaoProdutos.Ui.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoService _produtoService;

        public ProdutoController(IProdutoService produtoService)
        {            
            _produtoService = produtoService;
        }

        [HttpGet]
        [Route("[action]/{id:int}")]
        public Produto GetProduto( int id)
        {
            var teste = _produtoService.GetProduto(id);
            return _produtoService.GetProduto(id);
        }

        [HttpGet]        
        [Route("[action]")]
        public IEnumerable<Produto> GetAll()
        {
            var teste = _produtoService.GetAll();
            return _produtoService.GetAll();
        }

        [HttpPost]
        [Route("[action]")]
        public void Add([FromBody] Produto produto)
        {
            _produtoService.Add(produto);

        }

        [HttpPost]
        [Route("[action]")]
        public void Update([FromBody] Produto produto)
        {
            _produtoService.Update(produto);

        }

        //[HttpDelete]
        [Route("[action]")]
        public void Delete(int Codigo)
        {
            _produtoService.Delete(Codigo);

        }
    }
}
