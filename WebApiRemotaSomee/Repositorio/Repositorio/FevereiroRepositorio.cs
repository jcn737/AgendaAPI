using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiRemotaSomee.Interface;
using WebApiRemotaSomee.Models;

namespace WebApiRemotaSomee.Repositorio.Repositorio
{
	public class FevereiroRepositorio : IFevereiroRepositorio
	{
		private List<Fevereiro> _fevereiro;

		public FevereiroRepositorio()
		{
			InicializaDados();
		}

		private void InicializaDados()
		{
			_fevereiro = DalHelper.GetFevereiro();
		}

		public IEnumerable<Fevereiro> All
		{
			get
			{
				return _fevereiro;
			}
		}
	}
}