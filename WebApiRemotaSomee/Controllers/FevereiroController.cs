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
    public class FevereiroController : ApiController
    {
		private readonly IFevereiroRepositorio _fevereiroRepositorio;

		public FevereiroController()
		{
			_fevereiroRepositorio = new FevereiroRepositorio();
		}

		// GET: api/Produtos
		[HttpGet]
		public IEnumerable<Fevereiro> GetFevereiro()
		{
			return _fevereiroRepositorio.All;
		}
	}
}
