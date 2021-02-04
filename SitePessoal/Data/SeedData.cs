using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SitePessoal.Data
{
    public class SeedData
    {
        private const string NOME_ADMIN = "nuno_rgf@hotmail.com";
        private const string PASSWORD_ADMIN = "Nuno290998";

       


        internal static async Task InsereAdministradorPadraoAsync(UserManager<IdentityUser> gestorUtilizadores)
        {
            IdentityUser utilizador = await gestorUtilizadores.FindByNameAsync(NOME_ADMIN);
            if (utilizador == null) 
            {
                utilizador = new IdentityUser(NOME_ADMIN);
                await gestorUtilizadores.CreateAsync(utilizador, PASSWORD_ADMIN);
               
            }
          


        }
        private static void InsereDadosFicticios(SitePessoalDbContext db)
        {
            if (db.Escolas.Any()) return;
            db.Escolas.AddRange(new Models.Escolas[] {
                new Models.Escolas
                {
                    Escola = "SECUNDÁRIA DE AFONSO DE ALBUQUERQUE",
                    Curso = "Curso de Línguas e Humanidades",
                    Nota = 13
                },
                new Models.Escolas
                {
                     Escola = "IPG",
                    Curso = "Programação .Net",
                    Nota = 0
                }

            });
          
            if (db.ExperienciaProfissional.Any()) return;
            db.ExperienciaProfissional.AddRange(new Models.ExperienciaProfissional[] {
                new Models.ExperienciaProfissional
                {
                   Trabalho = "Sai de Gatas",
                    Duracao = "2 anos",
                    Funcao= "Empregado de balcão"
                },
                new Models.ExperienciaProfissional
                {
                     Trabalho = "Sai de Gatas",
                    Duracao = "6 meses",
                    Funcao= "Técnico de Instalação"
                }
                });
            db.SaveChanges();
             

        }


    }
}
