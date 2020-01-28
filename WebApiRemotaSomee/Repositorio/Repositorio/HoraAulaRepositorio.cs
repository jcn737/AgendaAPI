using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiRemotaSomee.Interface;
using WebApiRemotaSomee.Models;

namespace WebApiRemotaSomee.Repositorio.Repositorio
{
	public class HoraAulaRepositorio : IHoraAulaRepositorio
	{
		private List<HoraAula> _horaAula;

		public HoraAulaRepositorio()
		{
			InicializaDados();
		}

		private void InicializaDados()
		{
			_horaAula = DalHelper.GetHoraAula();
		}

		public IEnumerable<HoraAula> All
		{
			get
			{
				return _horaAula;
			}
		}
	}
}