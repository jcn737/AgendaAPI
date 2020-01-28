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
    public class ListaMaterialController : ApiController
    {
		private readonly IListaMaterialRepositorio _listaMaterialRepositorio;

		public ListaMaterialController()
		{
			_listaMaterialRepositorio = new ListaMaterialRepositorio();
		}

		// GET: api/Produtos
		[HttpGet]
		public IEnumerable<ListaMaterial> GetListaMaterial()
		{
			return _listaMaterialRepositorio.All;
		}
	}
}
