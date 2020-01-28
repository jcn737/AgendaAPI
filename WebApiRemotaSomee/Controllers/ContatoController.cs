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
    public class ContatoController : ApiController
    {
		private readonly IContatoRepositorio _contatoRepositorio;

		public ContatoController()
		{
			_contatoRepositorio = new ContatoRepositorio();
		}

		// GET: api/Produtos
		[HttpGet]
		public IEnumerable<Contato> GetContato()
		{
			return _contatoRepositorio.All;
		}
	}
}
