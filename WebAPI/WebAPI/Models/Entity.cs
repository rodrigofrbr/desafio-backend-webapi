using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    //DataCriar e DataUpdate será herdado por qualquer model da aplicação
    public abstract class Entity
    {
        //DateTime permite acessar o atributo .Now que possui como valor hora local
        public DateTime DataCriar { get; set; }
        public DateTime DataUpdate { get; set; }
    }
}
