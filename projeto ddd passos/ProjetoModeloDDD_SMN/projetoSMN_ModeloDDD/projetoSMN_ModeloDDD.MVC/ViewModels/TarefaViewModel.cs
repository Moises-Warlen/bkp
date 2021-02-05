using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace projetoSMN_ModeloDDD.MVC.ViewModels
{
    public class TarefaViewModel
    { 

        [Key]
        public int Id { get; set; }
       
        public int UsuarioId { get; set; }
        public int StatusTarefaId { get; set; }
        [Required(ErrorMessage = "Preenche o campo Descricao")]
        [MaxLength(100, ErrorMessage = "Maximo {0} caracteres")]
      
        public string Descricao { get; set; }
        [Required(ErrorMessage = "Preenche o campo Descricao")]
        DateTime DataInicio { get; set; }
        DateTime DataFim { get; set; }
        //public virtual Usuario Usuario { get; set; }
        //public virtual StatusTarefa StatusTarefa { get; set; }

    }
}