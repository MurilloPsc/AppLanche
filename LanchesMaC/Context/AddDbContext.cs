using LanchesMaC.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanchesMaC.Context
{
    public class AddDbContext : DbContext
    {
        public AddDbContext(DbContextOptions<AddDbContext> options) : base(options)
        {

        }

        public DbSet<Lanche> Lanches { get; set; }

        public DbSet<Categoria> Categorias { get; set; }

    }
}
