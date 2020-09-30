using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    //Herdando o comportamento de Entity...
    public class Tarefa : Entity
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
    }
}
