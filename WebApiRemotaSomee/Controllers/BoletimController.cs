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
    public class BoletimController : ApiController
    {
		private readonly IBoletimRepositorio _boletimRepositorio;

		public BoletimController()
		{
			_boletimRepositorio = new BoletimRepositorio();
		}

		// GET: api/Produtos
		[HttpGet]
		public IEnumerable<Boletim> GetBoletim()
		{
			return _boletimRepositorio.All;
		}
	}
}
