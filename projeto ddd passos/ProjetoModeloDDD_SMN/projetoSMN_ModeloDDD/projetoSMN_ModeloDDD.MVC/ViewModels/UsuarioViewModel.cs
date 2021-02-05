using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using projetoSMN_ModeloDDD.Dominio.Entidades;

namespace projetoSMN_ModeloDDD.MVC.ViewModels
{
    public class UsuarioViewModel
    {
        [Key]
        public int Id { get; set; }
       
     [Required(ErrorMessage =  "Preenche o campo nome")]
     [MaxLength(100, ErrorMessage= "Maximo {0} caracteres")]
     [MinLength(2, ErrorMessage = "Minimo de 2 caracteres")]
        public string Nome { get; set; }
        DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
       
        [Required(ErrorMessage = "Preenche o campo Email")]
        [MaxLength(100, ErrorMessage = "Maximo {0} caracteres")]
        [EmailAddress(ErrorMessage = "Preencher Com Email valido")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        public string Senha { get; set; }

        [Required(ErrorMessage = "Preenche o Endereço")]
        [MaxLength(100, ErrorMessage = "Maximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo de 2 caracteres")]
        public string Endereco { get; set; }
        public int IdGestor { get; set; }
        public virtual IEnumerable<Tarefa> Tarefa { get; set; }
       
        //public virtual Usuario Gestor { get; set; }
        //public virtual TipoUsuario TipoUsuario { get; set; }
    }
}