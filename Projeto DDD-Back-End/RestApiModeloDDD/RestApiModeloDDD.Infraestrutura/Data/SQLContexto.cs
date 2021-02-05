using Microsoft.EntityFrameworkCore;
using RestApiModeloDDD.Dominio.Entidades;
using System;
using System.Linq;

namespace RestApiModeloDDD.Infraestrutura.Data
{
   public class SQLContexto:DbContext
    {
        public SQLContexto()
        {

        }
        public SQLContexto(DbContextOptions<SQLContexto>options) : base(options) { }
        public DbSet<Cliente>Clientes { get; set; }
        public DbSet<Produto>Produtos { get; set; }

        public override int SaveChanges()
        { 
            foreach (var entry in ChangeTracker.Entries().Where(Entry => Entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {



                if(entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }
            }
           
            return base.SaveChanges();
        }


    }
}
