using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PetshopSystem.Models;
using PetshopSystem.Services.Validacoes;

namespace PetshopSystem.Services
{
    public class ResponsavelService
    {

        public static ResponsavelModel InstanciarResponsavel(string nome, string telefone, string email)
        {
            string nomeDefinitivo = ValidacoesGerais.FormatarParaMinusculo(nome);
            string telefoneDefinitivo = TratarTelefone(telefone);
            string emailDefinitivo = TratarEmail(email);

            ResponsavelModel responsavel = new ResponsavelModel 
            { 
                Nome = nomeDefinitivo,
                Telefone = telefoneDefinitivo,
                Email = emailDefinitivo
            };

            return responsavel;
        }

        public static string TratarTelefone(string telefone)
        {
            if(telefone.Length == 11)
            {
                return telefone;
            }
            else
            {
                throw new ArgumentException ("Formatação inválida");
            }
        }

        public static string TratarEmail(string email)
        {
            if (email.Contains("@"))
            {
                return email;
            }
            else
            {
                throw new ArgumentException ("Email Incorreto");
            }
        }
    }
}