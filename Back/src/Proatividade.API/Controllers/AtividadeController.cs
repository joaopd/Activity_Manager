using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Back.src.Proatividade.API.Models;
namespace Back.src.Proatividade.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AtividadeController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Atividade> Get()
        {
            return new List<Atividade>{
                new Atividade(1)
            };
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return $"Meu primeiro Get com parametro {id}";
        }


        [HttpPut("{id}")]
        public Atividade Put(int id, Atividade atividade)
        {
            atividade.Id = id + 1;
            return atividade;
        }

        [HttpPost]
        public string Post(Atividade atividade)
        {
            return "Meu primeiro Post";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return "Meu primeiro Delete";
        }
    }
}