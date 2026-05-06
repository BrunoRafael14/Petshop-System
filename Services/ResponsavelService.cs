using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PetshopSystem.Models;

namespace PetshopSystem.Services
{
    public class ResponsavelService
    {

        public static ResponsavelModel InstanciarResponsavel(string nome, string telefone, string email)
        {
            string nomeDefinitivo = FiltrarNome(nome);
            string telefoneDefinitivo = FiltrarTelefone(telefone);
            string emailDefinitivo = FiltrarEmail(email);

            ResponsavelModel responsavel = new ResponsavelModel 
            { 
                Nome = nomeDefinitivo,
                Telefone = telefoneDefinitivo,
                Email = emailDefinitivo
            };

            return responsavel;
        }

        public static string FiltrarTelefone(string telefone)
        {
            if(telefone.Length == 11)
            {
                return telefone;
            }
            else
            {
                return "Formatação inválida";
            }
        }

        public static string FiltrarNome(string nome)
        {
            string nomeAtualizado = nome.ToLower();
            return nomeAtualizado;
        }

        public static string FiltrarEmail(string email)
        {
            if (email.Contains("@"))
            {
                return email;
            }
            else
            {
                return "Email Incorreto";
            }
        }
    }
}