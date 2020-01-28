using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiRemotaSomee.Models
{
	public class Boletim
	{
		public virtual Aluno Aluno { get; set; }
		public int ID_Aluno { get; set; }
		public string Nome { get; set; }
		public Double Matematica { get; set; }
		public Double Portugues { get; set; }
		public Double Geografia { get; set; }
		public Double Ingles { get; set; }
		public Double Fisica { get; set; }
		public Double Quimica { get; set; }
		public Double Biologia { get; set; }
		public Double Artes { get; set; }
		public Double Musica { get; set; }
		public Double EducacaoFisica { get; set; }
		public Double AtividadesComplementares { get; set; }
	}
	public class HoraAula
	{
		public virtual Aluno Aluno { get; set; }
		public int ID_Aluno { get; set; }
		public string Segunda { get; set; }
		public string Terca { get; set; }
		public string Quarta { get; set; }
		public string Quinta { get; set; }
		public string Sexta { get; set; }
		public string Sabado { get; set; }
	}
	public class ListaMaterial
	{
		public virtual Aluno Aluno { get; set; }
		public int ID_Aluno { get; set; }
		public string Primeira { get; set; }
		public string Segunda { get; set; }
		public string Terceira { get; set; }
		public string Quarta { get; set; }
		public string Quinta { get; set; }
		public string Sexta { get; set; }
		public string Setima { get; set; }
		public string Oitava { get; set; }
		public string Nona { get; set; }
	}
	public class Reunioes
	{
		public virtual Aluno Aluno { get; set; }
		public int ID_Aluno { get; set; }
		public string Nova { get; set; }
		public string Agendadas { get; set; }
		public DateTime Data_Nova { get; set; }
		public DateTime Data_Agendadas { get; set; }
		public DateTime Data_Marcar { get; set; }
		public DateTime Hora_Nova { get; set; }
		public DateTime Hora_Agendadas { get; set; }
		public DateTime Hora_Marcar { get; set; }
	}
	public class RoteiroEstudos
	{
		public virtual Aluno Aluno { get; set; }
		public int ID_Aluno { get; set; }
		public string Primeira { get; set; }
		public string Segunda { get; set; }
		public string Terceira { get; set; }
		public string Quarta { get; set; }
		public string Quinta { get; set; }
		public string Sexta { get; set; }
		public string Setima { get; set; }
		public string Oitava { get; set; }
		public string Nona { get; set; }
	}
	public class Comunicados
	{
		public virtual Aluno Aluno { get; set; }
		public int ID_Aluno { get; set; }
		public string Primeira { get; set; }
		public string Segunda { get; set; }
		public string Terceira { get; set; }
		public string Quarta { get; set; }
		public string Quinta { get; set; }
		public string Sexta { get; set; }
		public string Setima { get; set; }
		public string Oitava { get; set; }
		public string Nona { get; set; }
	}
}