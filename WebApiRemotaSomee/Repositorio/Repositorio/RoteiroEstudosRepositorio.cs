using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiRemotaSomee.Interface;
using WebApiRemotaSomee.Models;

namespace WebApiRemotaSomee.Repositorio.Repositorio
{
	public class RoteiroEstudosRepositorio : IRoteiroEstudosRepositorio
	{
		private List<RoteiroEstudos> _roteiroEstudos;

		public RoteiroEstudosRepositorio()
		{
			InicializaDados();
		}

		private void InicializaDados()
		{
			_roteiroEstudos = DalHelper.GetRoteiroEstudos();
		}

		public IEnumerable<RoteiroEstudos> All
		{
			get
			{
				return _roteiroEstudos;
			}
		}
	}
}