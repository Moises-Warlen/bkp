using System;

namespace RestApiModeloDDD.Dominio.Entidades
{
    public class Cliente : Base
    {
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
    }
}
