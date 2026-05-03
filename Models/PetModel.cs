using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetshopSystem.Models
{
    public class PetModel
    {
        public string? Nome {get; set;}
        public string? Especie {get; set;}
        public string? Raca {get; set;}
        public char Sexo {get; set;}
        public int Idade {get; set;}
        public double Peso {get; set;}
        public int ResponsavelId {get; set;}
    }
}