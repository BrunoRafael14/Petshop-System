using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetshopSystem.Models
{
    public class AgendamentoModel
    {
        public string? TipoServico {get; set;}
        public string? Status {get; set;}
        public string? Restricoes {get; set;}
        public string? PreferenciasEsteticas {get; set;}
        public int PetId {get; set;}
    }
}