using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiRemotaSomee.Interface;
using WebApiRemotaSomee.Models;

namespace WebApiRemotaSomee.Repositorio.Repositorio
{
	public class BoletimRepositorio : IBoletimRepositorio
	{
		private List<Boletim> _boletim;

		public BoletimRepositorio()
		{
			InicializaDados();
		}

		private void InicializaDados()
		{
			_boletim = DalHelper.GetBoletim();
		}

		public IEnumerable<Boletim> All
		{
			get
			{
				return _boletim;
			}
		}
	}
}