using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projetoSMN_ModeloDDD.Dominio.Entidades;

namespace projetoSMN_ModeloDDD.Dominio.Interfacaces
{
    public interface IUsuarioRepositorio :IRepositorioBase<Usuario>

    {
        IEnumerable<TipoUsuario> BuscarTiposTipoUsuarios();


    }
}
