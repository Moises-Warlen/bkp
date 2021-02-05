using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using projetoSMN_ModeloDDD.Infra.Dados.Repositorios;

namespace projetoSMN_ModeloDDD.Api.Controllers
{
    [RoutePrefix("usuario")]
    public class UsuarioController : ApiController
    {
        private readonly UsuarioRepositorio _usuarioRepositorio;

        public UsuarioController()
        {
            _usuarioRepositorio = new UsuarioRepositorio();
        }
        public IHttpActionResult GetTiposUsuarios()
        {
             return  Ok( _usuarioRepositorio.BuscarTiposTipoUsuarios());

        }
    }
}
