using Microsoft.AspNetCore.Mvc;
using ProdutoAPI.Models;
using System.Collections.Generic;

namespace ProdutosAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private static List<Produto> produtos = new List<Produto>
        {
            new Produto { Id = 1, Nome = "Produto 1", Preco = 10.0m, Descricao = "Descrição do Produto 1" },
            new Produto { Id = 2, Nome = "Produto 2", Preco = 20.0m, Descricao = "Descrição do Produto 2" },
            new Produto { Id = 3, Nome = "Produto 3", Preco = 30.0m, Descricao = "Descrição do Produto 3" }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Produto>> Get()
        {
            return produtos;
        }

        [HttpGet("{id}")]
        public ActionResult<Produto> Get(int id)
        {
            var produto = produtos.Find(p => p.Id == id);
            if (produto == null)
            {
                return NotFound();
            }
            return produto;
        }
    }
}
