using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiRemotaSomee.Interface;
using WebApiRemotaSomee.Models;

namespace WebApiRemotaSomee.Repositorio.Repositorio
{
	public class JaneiroRepositorio : IJaneiroRepositorio
	{
		private List<Janeiro> _janeiro;

		public JaneiroRepositorio()
		{
			InicializaDados();
		}

		private void InicializaDados()
		{
			_janeiro = DalHelper.GetJaneiro();
		}
		
		public IEnumerable<Janeiro> All
		{
			get
			{
				return _janeiro;
			}
		}
	}
}