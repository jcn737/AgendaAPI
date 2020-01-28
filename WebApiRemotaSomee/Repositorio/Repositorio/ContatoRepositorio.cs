using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiRemotaSomee.Interface;
using WebApiRemotaSomee.Models;

namespace WebApiRemotaSomee.Repositorio.Repositorio
{
	public class ContatoRepositorio : IContatoRepositorio
	{
		private List<Contato> _contato;

		public ContatoRepositorio()
		{
			InicializaDados();
		}

		private void InicializaDados()
		{
			_contato = DalHelper.GetContato();
		}

		public IEnumerable<Contato> All
		{
			get
			{
				return _contato;
			}
		}

	}
}