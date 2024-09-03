using LojaVirtual.Models;
using Microsoft.EntityFrameworkCore;

namespace LojaVirtual.Database
{
    public class LojaVirtualContext : DbContext
    {
        /*
         EF Core -ORM
         SQL > 
         ORM > Biblioteca mapear Objetos P/ Banco de dados relacionais
         */

        public LojaVirtualContext(DbContextOptions<LojaVirtualContext> options): base(options) 
        { 
            
        }


        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<NewsletterEmail> NewsletterEmails { get;set; }

        public DbSet<Colaborador> Colaboradores { get; set; }

    }
}
