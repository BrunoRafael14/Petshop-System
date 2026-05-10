using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PetshopSystem.Models;
using PetshopSystem.Services.Validacoes;

namespace PetshopSystem.Services
{
    public class VacinaService
    {
        public static VacinaModel InstanciarVacina(string nome, int petId)
        {
            string nomeDefinitivo = ValidacoesGerais.FormatarParaMinusculo(nome);
            
            VacinaModel vacina = new VacinaModel 
            { 
                Nome = nomeDefinitivo,
                PetId = petId 
            };

            return vacina;
        }
        
        // public static int ValidarPetId(int id)
        // {
        //     if (condicao para entrar no banco)
        //     {
        //         return id;
        //     }
        //     else
        //     {
        //         throw new ArgumentException("Id inválido");
        //     }
        // }

    }
}