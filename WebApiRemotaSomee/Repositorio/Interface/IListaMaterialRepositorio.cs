using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiRemotaSomee.Models;

namespace WebApiRemotaSomee.Interface
{
	public interface IListaMaterialRepositorio
	{
		IEnumerable<ListaMaterial> All { get; }
	}
}
