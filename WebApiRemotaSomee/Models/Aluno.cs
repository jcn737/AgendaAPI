using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApiRemotaSomee.Models
{
    public class Aluno
    {
        [Key]
		public string Nome { get; set; }
		public int ID_Aluno { get; set; }		
		public int Idade { get; set; }
		public int Serie { get; set; }
		public string Nome_Mae { get; set; }
		public string Nome_Pai { get; set; }
		public string Nome_Professora { get; set; }
		public int Telefone { get; set; }
		public string Email { get; set; }
		public string Periodo { get; set; }
		public string Turma { get; set; }
	}
}