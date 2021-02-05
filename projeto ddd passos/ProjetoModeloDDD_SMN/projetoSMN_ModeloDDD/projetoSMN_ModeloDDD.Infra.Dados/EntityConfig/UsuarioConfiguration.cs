using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projetoSMN_ModeloDDD.Dominio.Entidades;

namespace projetoSMN_ModeloDDD.Infra.Dados.EntityConfig
{
   public class UsuarioConfiguration: EntityTypeConfiguration<Usuario>
    {
        public UsuarioConfiguration()
        {
            HasKey(u => u.Id);

            Property(u => u.Nome)
                .IsRequired()
                .HasMaxLength(50);


            Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(200);

            Property(u => u.Endereco)
                .IsRequired()
                .HasMaxLength(100);
           
        }

      

    }
}
