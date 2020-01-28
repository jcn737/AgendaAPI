using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiRemotaSomee.Interface;
using WebApiRemotaSomee.Models;
using WebApiRemotaSomee.Repositorio.Repositorio;

namespace WebApiRemotaSomee.Controllers
{
    public class UsuariosController : ApiController
    {
		private readonly IUsuario _usuariosRepositorio;

		public UsuariosController()
		{
			_usuariosRepositorio = new UsuarioRepositorio();
		}

		// GET: api/Produtos
		[HttpGet]
		public IEnumerable<Usuarios> GetContato()
		{
			return _usuariosRepositorio.All;
		}
	}
}
