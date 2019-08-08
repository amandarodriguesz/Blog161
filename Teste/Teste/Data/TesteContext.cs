using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Teste.Models;

    public class TesteContext : DbContext
    {
        public TesteContext (DbContextOptions<TesteContext> options)
            : base(options)
        {
        }

        public DbSet<Teste.Models.Dono> Dono { get; set; }

        public DbSet<Teste.Models.Cao> Cao { get; set; }
    }
