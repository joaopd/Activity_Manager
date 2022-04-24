using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Back.src.Proatividade.API.Models
{
    public class Atividade
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Priroridade { get; set; }

        public Atividade()
        { }

        public Atividade(int id)
        {
            Id = id;
        }
    }
}