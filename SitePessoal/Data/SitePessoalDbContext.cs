using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using SitePessoal.Models;

namespace SitePessoal.Data
{
    public class SitePessoalDbContext : IdentityDbContext
    {
        public SitePessoalDbContext(DbContextOptions<SitePessoalDbContext> options)
            : base(options)
        {
        }
        public DbSet<SitePessoal.Models.Escolas> Escolas { get; set; }
        public DbSet<SitePessoal.Models.ExperienciaProfissional> ExperienciaProfissional { get; set; }
      
    }
}
