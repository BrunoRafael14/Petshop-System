using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PetshopSystem.Models;
using PetshopSystem.Services.Validacoes;

namespace PetshopSystem.Services
{
    public class PetService
    {
        public static PetModel InstanciarPet(string nome, string especie, string raca, char sexo, int idade, double peso, int responsavelId)
        {
            var nomeDefinitivo = TratarNome(nome);
            var especieDefinitivo = TratarEspecie(especie);
            var racaDefinitivo = TratarRaca(raca);
            var sexoDefinitivo = TratarSexo(sexo);
            var idadeDefinitivo = TratarIdade(idade);
            
            PetModel pet = new PetModel 
            { 
                Nome = nomeDefinitivo,
                Especie = especieDefinitivo,
                Raca = racaDefinitivo,
                Sexo = sexoDefinitivo,
                Idade = idadeDefinitivo,
                Peso = peso,
                ResponsavelId = responsavelId
            };

            return pet;
        }

        public static string TratarNome(string nome)
        {
            var nomePet = ValidacoesGerais.FormatarParaMinusculo(nome);
            return nomePet;
        }

        public static string TratarRaca(string raca)
        {
            var racaPet = ValidacoesGerais.FormatarParaMinusculo(raca);
            return racaPet;
        }

        public static string TratarEspecie(string especie)
        {
            var especiePet = ValidacoesGerais.FormatarParaMinusculo(especie);
            return especiePet;
        }

        public static char TratarSexo(char sexo)
        {
            char sexoFormatado = char.ToLower(sexo);
            if (sexoFormatado != 'm' && sexoFormatado != 'f')
            {
                throw new ArgumentException("Sexo inválido");
            }

            return sexoFormatado;
        }

        public static int TratarIdade(int idade)
        {
            if (idade > 35)
            {
                throw new ArgumentException ("Idade Inválida");
            }
            return idade;
        }

        // public static int ValidarResponsavelId(int id)
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