using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoSMN_ModeloDDD.Dominio.Entidades
{
    public class Imagem
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public string URL { get; set; }
      
        public virtual Usuario Usuario { get; set; }
    }
}
