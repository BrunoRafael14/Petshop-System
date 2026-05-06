using PetshopSystem.Services;
using PetshopSystem.Models;

var responsavel = ResponsavelService.InstanciarResponsavel("Bruno Rafael", "81998014421", "brunorafaelfilho10@gmail.com");

Console.WriteLine(responsavel.Nome);
Console.WriteLine(responsavel.Telefone);
Console.WriteLine(responsavel.Email);