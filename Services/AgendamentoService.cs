using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PetshopSystem.Models;
using PetshopSystem.Models.Enums;

namespace PetshopSystem.Services
{
    public class AgendamentoService
    {
        public static AgendamentoModel InstanciarAgendamento(string tipoServico, string status, string restricoes, string preferenciasEsteticas, DateTime dataHora, int petId)
        {
            var StatusDefinitivo = TratarStatus(status);
            var DataHoraDefinitivo = TratarDataHora(dataHora);

            AgendamentoModel agendamento = new AgendamentoModel 
            {
                TipoServico = tipoServico,
                Status = StatusDefinitivo,
                Restricoes = restricoes,
                PreferenciasEsteticas = preferenciasEsteticas,
                DataHora = DataHoraDefinitivo,
                PetId = petId
            };

            return agendamento;
        }

        public static string TratarStatus(string status)
        {
            if (!Enum.TryParse<Status>(status, ignoreCase: true, out _))
            {
                throw new ArgumentException("Status Inválido");
            }

            return status;
        }

        public static DateTime TratarDataHora(DateTime dataHora)
        {
            if (dataHora < DateTime.Now)
            {
                throw new ArgumentException ("Data e Hora Inválida");
            }
            
            return dataHora;
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