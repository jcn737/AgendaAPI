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
    public class HoraAulaController : ApiController
    {
		private readonly IHoraAulaRepositorio _horaAulaRepositorio;

		public HoraAulaController()
		{
			_horaAulaRepositorio = new HoraAulaRepositorio();
		}

		// GET: api/Produtos
		[HttpGet]
		public IEnumerable<HoraAula> GetHoraAula()
		{
			return _horaAulaRepositorio.All;
		}
	}
}
