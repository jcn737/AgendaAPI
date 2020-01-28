using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiRemotaSomee.Interface;
using WebApiRemotaSomee.Models;

namespace WebApiRemotaSomee.Repositorio.Repositorio
{
    public class AlunoRepositorio : IAlunoRepositorio
    {
		private List<Aluno> _aluno;

		public AlunoRepositorio()
		{
			InicializaDados();
		}

		private void InicializaDados()
		{
			_aluno = DalHelper.GetAlunos();
		}


		public IEnumerable<Aluno> All
		{
			get
			{
				return _aluno;
			}
		}

		public void Delete(string aluno)
		{
			DalHelper.DeleteAluno(aluno);
		}

		public Aluno Find(string aluno)
		{
			return DalHelper.GetAluno(aluno);
		}


		public void Insert(Aluno aluno)
		{
			if (aluno == null)
			{
				throw new ArgumentNullException("aluno");
			}
			DalHelper.InsertAluno(aluno);

		}

		public void Update(Aluno aluno)
		{
			if (aluno == null)
			{
				throw new ArgumentNullException("aluno");
			}
			DalHelper.UpdateAluno(aluno);
		}
	}
}