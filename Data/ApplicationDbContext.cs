using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ChrisMVC.EF;

namespace ChrisMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ChrisMVC.EF.Produtos> Produtos { get; set; }
        public DbSet<ChrisMVC.EF.Clientes> Clientes { get; set; }
        public DbSet<ChrisMVC.EF.Estoques> Estoques { get; set; }
    }
}
