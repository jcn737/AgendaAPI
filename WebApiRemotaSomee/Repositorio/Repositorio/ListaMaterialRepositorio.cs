using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiRemotaSomee.Interface;
using WebApiRemotaSomee.Models;

namespace WebApiRemotaSomee.Repositorio.Repositorio
{
	public class ListaMaterialRepositorio : IListaMaterialRepositorio
	{
		private List<ListaMaterial> _listaMaterial;

		public ListaMaterialRepositorio()
		{
			InicializaDados();
		}

		private void InicializaDados()
		{
			_listaMaterial = DalHelper.GetListaMaterial();
		}

		public IEnumerable<ListaMaterial> All
		{
			get
			{
				return _listaMaterial;
			}
		}
	}
}