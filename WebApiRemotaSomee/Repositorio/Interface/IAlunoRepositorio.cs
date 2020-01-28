using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiRemotaSomee.Models;

namespace WebApiRemotaSomee.Interface
{
    public interface IAlunoRepositorio
    {
        IEnumerable<Aluno> All { get; }
        Aluno Find(string nome);
        void Insert(Aluno item);
        void Update(Aluno item);
        void Delete(string nome);
    }
}
