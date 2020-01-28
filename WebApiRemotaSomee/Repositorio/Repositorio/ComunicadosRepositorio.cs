using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiRemotaSomee.Interface;
using WebApiRemotaSomee.Models;

namespace WebApiRemotaSomee.Repositorio.Repositorio
{
	public class ComunicadosRepositorio : IComunicadosRepositorio
	{
		private List<Comunicados> _comunicados;

		public ComunicadosRepositorio()
		{
			InicializaDados();
		}

		private void InicializaDados()
		{
			_comunicados = DalHelper.GetComunicados();
		}

		public IEnumerable<Comunicados> All
		{
			get
			{
				return _comunicados;
			}
		}
	}
}