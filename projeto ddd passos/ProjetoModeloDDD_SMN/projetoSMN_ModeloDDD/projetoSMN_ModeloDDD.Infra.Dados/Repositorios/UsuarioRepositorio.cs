using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projetoSMN_ModeloDDD.Dominio.Entidades;
using projetoSMN_ModeloDDD.Dominio.Interfacaces;

namespace projetoSMN_ModeloDDD.Infra.Dados.Repositorios
{
    public class UsuarioRepositorio : RepositorioBase<Usuario>,IUsuarioRepositorio

    {
        public IEnumerable<TipoUsuario> BuscarTiposTipoUsuarios()
        {
            return Db.Set<TipoUsuario>().ToList();
        }
    }
}
