using System;

namespace RestApiModeloDDD.Dominio.Entidades
{
   public class Produto : Base
    {
        public string Nome { get; set; }
        public Decimal Valor  { get; set; }
        public bool IsDiponivel { get; set; }
    }
}
