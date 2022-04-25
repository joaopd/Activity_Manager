using Microsoft.AspNetCore.Mvc;
using Proatividade.API.Data;
using Proatividade.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Proatividade.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AtividadeController : ControllerBase
    {
        private readonly DataContext _context;

        public AtividadeController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Atividade> Get()
        {
            return _context.Atividades;
        }

        [HttpGet("{id}")]
        public Atividade Get(int id)
        {
            return _context.Atividades.FirstOrDefault(x => x.Id.Equals(id));
        }


        [HttpPut("{id}")]
        public Atividade Put(int id, Atividade atividade)
        {
            if (atividade.Id != id) 
                throw new Exception("Voce esta tentando atualizar uma atividade errada");

            _context.Update(atividade);

            if (_context.SaveChanges() > 0)
                return _context.Atividades.FirstOrDefault(x => x.Id.Equals(id));
            else
                throw new Exception("Não foi possivel alterar a atividade");
        }

        [HttpPost]
        public Atividade Post(Atividade atividade)
        {
            _context.Atividades.Add(atividade);

            if (_context.SaveChanges() > 0)
                return atividade;
            else
                throw new Exception("Não foi possivel adicionar o item");
        }

        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            var ativ = _context.Atividades.FirstOrDefault(x => x.Id.Equals(id));

            if (ativ != null)
            {
                _context.Atividades.Remove(ativ);
                return _context.SaveChanges() > 0;
            }
            else
                throw new Exception("Não foi possivel excluir o itenm");
        }
    }
}