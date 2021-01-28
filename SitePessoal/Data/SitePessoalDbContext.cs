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
        public DbSet<SitePessoal.Models.Experiencia> Experiencia { get; set; }
    }
}
