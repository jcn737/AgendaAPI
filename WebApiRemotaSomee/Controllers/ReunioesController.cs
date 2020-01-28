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
    public class ReunioesController : ApiController
    {
		private readonly IReunioesRepositorio _reunioesRepositorio;

		public ReunioesController()
		{
			_reunioesRepositorio = new ReunioesRepositorio();
		}

		// GET: api/Produtos
		[HttpGet]
		public IEnumerable<Reunioes> GetReunioes()
		{
			return _reunioesRepositorio.All;
		}
	}
}
