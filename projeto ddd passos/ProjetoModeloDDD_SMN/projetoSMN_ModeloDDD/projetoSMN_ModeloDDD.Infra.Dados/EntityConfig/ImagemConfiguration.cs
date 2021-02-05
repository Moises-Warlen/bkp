using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projetoSMN_ModeloDDD.Dominio.Entidades;

namespace projetoSMN_ModeloDDD.Infra.Dados.EntityConfig
{
   public class ImagemConfiguration:EntityTypeConfiguration<Imagem>
    {
        public ImagemConfiguration()
        {

            HasKey(I => I.Id);

            Property(I => I.URL)
                .IsRequired()
                .HasMaxLength(150);

        }

    }
}
