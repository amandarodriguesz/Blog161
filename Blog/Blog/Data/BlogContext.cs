using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Blog.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

public class BlogContext : IdentityDbContext<User>
{
        public BlogContext (DbContextOptions<BlogContext> options)
            : base(options)
        {
        }

        public DbSet<Blog.Models.Categoria> Categoria { get; set; }

        public DbSet<Blog.Models.Mensagem> Mensagem { get; set; }

        public DbSet<Blog.Models.Comentario> Comentario { get; set; }
    }
