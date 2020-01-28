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
    public class ComunicadosController : ApiController
    {
		private readonly IComunicadosRepositorio _comunicadosRepositorio;

		public ComunicadosController()
		{
			_comunicadosRepositorio = new ComunicadosRepositorio();
		}

		// GET: api/Produtos
		[HttpGet]
		public IEnumerable<Comunicados> GetComunicados()
		{
			return _comunicadosRepositorio.All;
		}
	}
}
