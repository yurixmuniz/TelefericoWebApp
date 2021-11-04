using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TelefericoWebApp.Models;

namespace TelefericoWebApp.Data
{
    public class TelefericoWebAppContext : DbContext
    {
        public TelefericoWebAppContext (DbContextOptions<TelefericoWebAppContext> options)
            : base(options)
        {

        }

        public DbSet<TelefericoWebApp.Models.Usuario> Usuarios { get; set; }

        public DbSet<TelefericoWebApp.Models.Pedido> Pedidos { get; set; }

        public DbSet<TelefericoWebApp.Models.Produto> Produtos { get; set; }
    }
}
