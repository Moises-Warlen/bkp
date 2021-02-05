using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projetoSMN_ModeloDDD.Dominio.Entidades;

namespace projetoSMN_ModeloDDD.Infra.Dados.EntityConfig
{
    public class TipoUsuarioConfiguration : EntityTypeConfiguration<TipoUsuario>
    {

        public TipoUsuarioConfiguration()
        {
           

            Property(tu => tu.Descricao)
                .IsRequired()
                .HasMaxLength(50);


        }
     


    }
}
