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
    public class RoteiroEstudosController : ApiController
    {
		private readonly IRoteiroEstudosRepositorio _roteiroEstudosRepositorio;

		public RoteiroEstudosController()
		{
			_roteiroEstudosRepositorio = new RoteiroEstudosRepositorio();
		}

		// GET: api/Produtos
		[HttpGet]
		public IEnumerable<RoteiroEstudos> GetRoteiroEstudos()
		{
			return _roteiroEstudosRepositorio.All;
		}
	}
}
