using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiRemotaSomee.Interface;
using WebApiRemotaSomee.Models;

namespace WebApiRemotaSomee.Repositorio.Repositorio
{
	public class UsuarioRepositorio : IUsuario
	{
		private List<Usuarios> _usuarios;

		public UsuarioRepositorio()
		{
			InicializaDados();
		}

		private void InicializaDados()
		{
			_usuarios = DalHelper.GetUsuario();
		}

		public IEnumerable<Usuarios> All
		{
			get
			{
				return _usuarios;
			}
		}
	}
}