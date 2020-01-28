using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiRemotaSomee.Interface;
using WebApiRemotaSomee.Models;
using WebApiRemotaSomee.Repositorio.Repositorio;

namespace WebApiRemotaSomee.Controllers
{
    public class AlunosController : ApiController
    {
        private readonly IAlunoRepositorio _alunoRepositorio;

        public AlunosController()
        {
            _alunoRepositorio = new AlunoRepositorio();
        }
		
        // GET: api/Produtos
        [HttpGet]
        public IEnumerable<Aluno> List()
        {
            return _alunoRepositorio.All;
        }

        // GET: api/Produtos/5
        public Aluno GetAluno(string aluno)
        {
            var alunos = _alunoRepositorio.Find(aluno);

            if (aluno == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
            }
            return alunos;
        }

        // POST: api/Produtos   
        [HttpPost()]
        public void Post([FromBody]Aluno aluno)
        {
            _alunoRepositorio.Insert(aluno);
        }

        // PUT: api/Produtos/5
        [HttpPut()]
        public void Put(string nome, [FromBody] Aluno aluno)
        {
			aluno.Nome = nome;
            _alunoRepositorio.Update(aluno);
        }

        // DELETE: api/Produtos/5
        [HttpDelete()]
        public void Delete(string nome)
        {
            _alunoRepositorio.Delete(nome);
        }
    }
}
