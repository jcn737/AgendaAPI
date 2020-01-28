using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiRemotaSomee.Interface;
using WebApiRemotaSomee.Models;

namespace WebApiRemotaSomee.Repositorio.Repositorio
{
	public class ReunioesRepositorio : IReunioesRepositorio
	{
		private List<Reunioes> _reunioes;

		public ReunioesRepositorio()
		{
			InicializaDados();
		}

		private void InicializaDados()
		{
			_reunioes = DalHelper.GetReunioes();
		}

		public IEnumerable<Reunioes> All
		{
			get
			{
				return _reunioes;
			}
		}
	}
}