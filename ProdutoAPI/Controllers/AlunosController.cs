using Microsoft.AspNetCore.Mvc;
using ProdutoAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProdutoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private static List<Aluno> alunos = new List<Aluno>
        {
            new Aluno { Id = 10, Nome = "Jeferson Wilians", Email = "jwil@gmail.com", Serie = 9 },
            new Aluno { Id = 30, Nome = "Wilians Arthur", Email = "art.will@gmail.com", Serie = 5 },
            new Aluno { Id = 40, Nome = "Lins", Email = "lins@gmail.com", Serie = 1 }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Aluno>> Get()
        {
            return Ok(alunos);
        }

        [HttpGet("{id}")]
        public ActionResult<Aluno> Get(int id)
        {
            var aluno = alunos.FirstOrDefault(p => p.Id == id);
            if (aluno == null)
            {
                return NotFound();
            }
            return Ok(aluno);
        }
    }
}
