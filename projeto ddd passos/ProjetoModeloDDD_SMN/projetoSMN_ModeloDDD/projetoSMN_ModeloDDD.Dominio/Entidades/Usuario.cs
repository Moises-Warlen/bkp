
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoSMN_ModeloDDD.Dominio.Entidades
{
    public class Usuario
    {
        public int Id { get; set; }
        public int TipoUsuarioId { get; set; }
      

        public string Nome { get; set; }
        DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Endereco { get; set; }
        public int IdGestor { get; set; }
        public virtual IEnumerable<Tarefa> Tarefa { get; set; }
        [ForeignKey("IdGestor")]
        public virtual Usuario Gestor {get; set; }
        public virtual TipoUsuario TipoUsuario { get; set; }

    }
}
