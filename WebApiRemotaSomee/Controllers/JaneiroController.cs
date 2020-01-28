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
    public class JaneiroController : ApiController
    {
		private readonly IJaneiroRepositorio _janeiroRepositorio;

		public JaneiroController()
		{
			_janeiroRepositorio = new JaneiroRepositorio();
		}

		// GET: api/Produtos
		[HttpGet]
		public IEnumerable<Janeiro> GetJaneiro()
		{
			return _janeiroRepositorio.All;
		}
	}
}
