using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projetoSMN_ModeloDDD.Dominio.Entidades;
using projetoSMN_ModeloDDD.Infra.Dados.EntityConfig;

namespace projetoSMN_ModeloDDD.Infra.Dados.Contexto
{
    public class ProjetoModeloContext:DbContext
    {
        public ProjetoModeloContext()
            :base("projetoModeloDDD")
        {
        }

        public DbSet<TipoUsuario> TipoUsuarios { get; set; }

        public DbSet<Imagem> Imagems { get; set; }

        public DbSet<Tarefa> Tarefas { get; set; }

        public DbSet<StatusTarefa> StatusTarefas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                    .Configure(p => p.IsKey());

                modelBuilder.Properties<string>()
                    .Configure(p=>p.HasColumnType("varchar"));


                modelBuilder.Properties<string>()
                    .Configure(p => p.HasMaxLength(100));

               modelBuilder.Configurations.Add(new UsuarioConfiguration());
              modelBuilder.Configurations.Add(new ImagemConfiguration());
            modelBuilder.Configurations.Add(new StatusTarefaConfiguration());
            modelBuilder.Configurations.Add(new TipoUsuarioConfiguration());
            modelBuilder.Configurations.Add(new TarefaConfiguration());


        }

        //public override int SaveChanges()
        //{
        //    foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataNascimento") != null))
        //    {
        //        if (entry.State == EntityState.Added)
        //        {
        //            entry.Property("DataNascimento").CurrentValue = DateTime.Now;
                
        //        }
        //        //if (entry.State == EntityState.Modified)
        //        //{
        //        //    entry.Property("DataNascimento").IsModified = false;

        //        //}

                
            //}
            //return base.SaveChanges();
        



    }
}
