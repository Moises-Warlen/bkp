using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoSMN_ModeloDDD.Dominio.Entidades
{
    public class Tarefa
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int StatusTarefaId { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }

        public virtual Usuario Usuario { get; set; }
        public virtual StatusTarefa StatusTarefa { get; set; }
    }
}
