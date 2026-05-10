using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetshopSystem.Services.Validacoes
{
    public class ValidacoesGerais
    {
        public static string FormatarParaMinusculo(string nome)
        {
            string nomeAtualizado = nome.ToLower();
            return nomeAtualizado;
        }
    }
}