using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Http;

namespace WebApiRemotaSomee.Models
{
	public class DalHelper
	{
		protected static string GetStringConexao()
		{
			return ConfigurationManager.ConnectionStrings["conexaoSQLServer"].ConnectionString;
		}

		public static List<Aluno> GetAlunos()
		{
			List<Aluno> _alunos = new List<Aluno>();
			using (SqlConnection con = new SqlConnection(GetStringConexao()))
			{
				con.Open();
				using (SqlCommand cmd = new SqlCommand("SELECT * FROM Aluno", con))
				{
					using (SqlDataReader dr = cmd.ExecuteReader())
					{
						if (dr != null)
						{
							while (dr.Read())
							{
								var aluno = new Aluno();
								aluno.Nome = dr["Nome"].ToString();
								aluno.Idade = Convert.ToInt32(dr["Idade"]);
								aluno.Serie = Convert.ToInt32(dr["Serie"]);
								aluno.Nome_Mae = dr["Nome_Mae"].ToString();
								aluno.Nome_Pai = dr["Nome_Pai"].ToString();
								aluno.Nome_Professora = dr["Nome_Professora"].ToString();
								aluno.Telefone = Convert.ToInt32(dr["Telefone"]);
								aluno.Email = dr["Email"].ToString();
								aluno.Periodo = dr["Periodo"].ToString();
								aluno.Turma = dr["Turma"].ToString();
								_alunos.Add(aluno);
							}
						}
						return _alunos;
					}
				}
			}
		}
		public static Aluno GetAluno(string nome)
		{
			Aluno aluno = null;
			using (SqlConnection con = new SqlConnection(GetStringConexao()))
			{
				con.Open();
				using (SqlCommand cmd = new SqlCommand("SELECT * FROM Aluno Where Nome=" + nome, con))
				{
					using (SqlDataReader dr = cmd.ExecuteReader())
					{
						if (dr != null)
						{
							while (dr.Read())
							{
								aluno = new Aluno();
								aluno.Nome = dr["Nome"].ToString();
								aluno.Idade = Convert.ToInt32(dr["Idade"]);
								aluno.Serie = Convert.ToInt32(dr["Serie"]);
								aluno.Nome_Mae = dr["Nome_Mae"].ToString();
								aluno.Nome_Pai = dr["Nome_Pai"].ToString();
								aluno.Nome_Professora = dr["Nome_Professora"].ToString();
								aluno.Telefone = Convert.ToInt32(dr["Telefone"]);
								aluno.Email = dr["Email"].ToString();
							}
						}
						return aluno;
					}
				}
			}
		}

		public static List<Janeiro> GetJaneiro()
		{
			List<Janeiro> _janeiro = new List<Janeiro>();
			using (SqlConnection con = new SqlConnection(GetStringConexao()))
			{
				con.Open();
				using (SqlCommand cmd = new SqlCommand("SELECT * FROM Janeiro", con))
				{
					using (SqlDataReader dr = cmd.ExecuteReader())
					{
						if (dr != null)
						{
							while (dr.Read())
							{
								var janeiro = new Janeiro();
								janeiro.Um = dr["Dois"].ToString();
								janeiro.Dois = dr["Um"].ToString();
								janeiro.Tres = dr["Tres"].ToString();
								janeiro.Quatro = dr["Quatro"].ToString();
								janeiro.Cinco = dr["Cinco"].ToString();
								janeiro.Seis = dr["Seis"].ToString();
								janeiro.Sete = dr["Sete"].ToString();
								janeiro.Oito = dr["Oito"].ToString();
								janeiro.Nove = dr["Nove"].ToString();
								janeiro.Dez = dr["Dez"].ToString();
								janeiro.Onze = dr["Onze"].ToString();
								janeiro.Doze = dr["Doze"].ToString();
								janeiro.Treze = dr["Treze"].ToString();
								janeiro.Quatorze = dr["Quatorze"].ToString();
								janeiro.Quinze = dr["Quinze"].ToString();
								janeiro.Dezesseis = dr["Dezesseis"].ToString();
								janeiro.Dezessete = dr["Dezessete"].ToString();
								janeiro.Dezoito = dr["Dezoito"].ToString();
								janeiro.Dezenove = dr["Dezenove"].ToString();
								janeiro.Vinte = dr["Vinte"].ToString();
								janeiro.Vinte_Um = dr["Vinte_Um"].ToString();
								janeiro.Vinte_Dois = dr["Vinte_Dois"].ToString();
								janeiro.Vinte_Tres = dr["Vinte_Tres"].ToString();
								janeiro.Vinte_Quatro = dr["Vinte_Quatro"].ToString();
								janeiro.Vinte_Cinco = dr["Vinte_Cinco"].ToString();
								janeiro.Vinte_Seis = dr["Vinte_Seis"].ToString();
								janeiro.Vinte_Sete = dr["Vinte_Sete"].ToString();
								janeiro.Vinte_Oito = dr["Vinte_Oito"].ToString();
								janeiro.Vinte_Nove = dr["Vinte_Nove"].ToString();
								janeiro.Trinta = dr["Trinta"].ToString();
								janeiro.Trinta_Um = dr["Trinta_Um"].ToString();
								_janeiro.Add(janeiro);
							}
						}
						return _janeiro;
					}
				}
			}
		}
		public static List<Fevereiro> GetFevereiro()
		{
			List<Fevereiro> _fevereiro = new List<Fevereiro>();
			using (SqlConnection con = new SqlConnection(GetStringConexao()))
			{
				con.Open();
				using (SqlCommand cmd = new SqlCommand("SELECT * FROM Fevereiro", con))
				{
					using (SqlDataReader dr = cmd.ExecuteReader())
					{
						if (dr != null)
						{
							while (dr.Read())
							{
								var fevereiro = new Fevereiro();
								fevereiro.Um = dr["Dois"].ToString();
								fevereiro.Dois = dr["Um"].ToString();
								fevereiro.Tres = dr["Tres"].ToString();
								fevereiro.Quatro = dr["Quatro"].ToString();
								fevereiro.Cinco = dr["Cinco"].ToString();
								fevereiro.Seis = dr["Seis"].ToString();
								fevereiro.Sete = dr["Sete"].ToString();
								fevereiro.Oito = dr["Oito"].ToString();
								fevereiro.Nove = dr["Nove"].ToString();
								fevereiro.Dez = dr["Dez"].ToString();
								fevereiro.Onze = dr["Onze"].ToString();
								fevereiro.Doze = dr["Doze"].ToString();
								fevereiro.Treze = dr["Treze"].ToString();
								fevereiro.Quatorze = dr["Quatorze"].ToString();
								fevereiro.Quinze = dr["Quinze"].ToString();
								fevereiro.Dezesseis = dr["Dezesseis"].ToString();
								fevereiro.Dezessete = dr["Dezessete"].ToString();
								fevereiro.Dezoito = dr["Dezoito"].ToString();
								fevereiro.Dezenove = dr["Dezenove"].ToString();
								fevereiro.Vinte = dr["Vinte"].ToString();
								fevereiro.Vinte_Um = dr["Vinte_Um"].ToString();
								fevereiro.Vinte_Dois = dr["Vinte_Dois"].ToString();
								fevereiro.Vinte_Tres = dr["Vinte_Tres"].ToString();
								fevereiro.Vinte_Quatro = dr["Vinte_Quatro"].ToString();
								fevereiro.Vinte_Cinco = dr["Vinte_Cinco"].ToString();
								fevereiro.Vinte_Seis = dr["Vinte_Seis"].ToString();
								fevereiro.Vinte_Sete = dr["Vinte_Sete"].ToString();
								fevereiro.Vinte_Oito = dr["Vinte_Oito"].ToString();
								fevereiro.Vinte_Nove = dr["Vinte_Nove"].ToString();
								_fevereiro.Add(fevereiro);
							}
						}
						return _fevereiro;
					}
				}
			}
		}
		public static List<Marco> GetMarco()
		{
			List<Marco> _marco = new List<Marco>();
			using (SqlConnection con = new SqlConnection(GetStringConexao()))
			{
				con.Open();
				using (SqlCommand cmd = new SqlCommand("SELECT * FROM Marco", con))
				{
					using (SqlDataReader dr = cmd.ExecuteReader())
					{
						if (dr != null)
						{
							while (dr.Read())
							{
								var marco = new Marco();
								marco.Um = dr["Dois"].ToString();
								marco.Dois = dr["Um"].ToString();
								marco.Tres = dr["Tres"].ToString();
								marco.Quatro = dr["Quatro"].ToString();
								marco.Cinco = dr["Cinco"].ToString();
								marco.Seis = dr["Seis"].ToString();
								marco.Sete = dr["Sete"].ToString();
								marco.Oito = dr["Oito"].ToString();
								marco.Nove = dr["Nove"].ToString();
								marco.Dez = dr["Dez"].ToString();
								marco.Onze = dr["Onze"].ToString();
								marco.Doze = dr["Doze"].ToString();
								marco.Treze = dr["Treze"].ToString();
								marco.Quatorze = dr["Quatorze"].ToString();
								marco.Quinze = dr["Quinze"].ToString();
								marco.Dezesseis = dr["Dezesseis"].ToString();
								marco.Dezessete = dr["Dezessete"].ToString();
								marco.Dezoito = dr["Dezoito"].ToString();
								marco.Dezenove = dr["Dezenove"].ToString();
								marco.Vinte = dr["Vinte"].ToString();
								marco.Vinte_Um = dr["Vinte_Um"].ToString();
								marco.Vinte_Dois = dr["Vinte_Dois"].ToString();
								marco.Vinte_Tres = dr["Vinte_Tres"].ToString();
								marco.Vinte_Quatro = dr["Vinte_Quatro"].ToString();
								marco.Vinte_Cinco = dr["Vinte_Cinco"].ToString();
								marco.Vinte_Seis = dr["Vinte_Seis"].ToString();
								marco.Vinte_Sete = dr["Vinte_Sete"].ToString();
								marco.Vinte_Oito = dr["Vinte_Oito"].ToString();
								marco.Vinte_Nove = dr["Vinte_Nove"].ToString();
								marco.Trinta = dr["Trinta"].ToString();
								marco.Trinta_Um = dr["Trinta_Um"].ToString();
								_marco.Add(marco);
							}
						}
						return _marco;
					}
				}
			}
		}
		public static List<Abril> GetAbril()
		{
			List<Abril> _abril = new List<Abril>();
			using (SqlConnection con = new SqlConnection(GetStringConexao()))
			{
				con.Open();
				using (SqlCommand cmd = new SqlCommand("SELECT * FROM Abril", con))
				{
					using (SqlDataReader dr = cmd.ExecuteReader())
					{
						if (dr != null)
						{
							while (dr.Read())
							{
								var abril = new Abril();
								abril.Um = dr["Dois"].ToString();
								abril.Dois = dr["Um"].ToString();
								abril.Tres = dr["Tres"].ToString();
								abril.Quatro = dr["Quatro"].ToString();
								abril.Cinco = dr["Cinco"].ToString();
								abril.Seis = dr["Seis"].ToString();
								abril.Sete = dr["Sete"].ToString();
								abril.Oito = dr["Oito"].ToString();
								abril.Nove = dr["Nove"].ToString();
								abril.Dez = dr["Dez"].ToString();
								abril.Onze = dr["Onze"].ToString();
								abril.Doze = dr["Doze"].ToString();
								abril.Treze = dr["Treze"].ToString();
								abril.Quatorze = dr["Quatorze"].ToString();
								abril.Quinze = dr["Quinze"].ToString();
								abril.Dezesseis = dr["Dezesseis"].ToString();
								abril.Dezessete = dr["Dezessete"].ToString();
								abril.Dezoito = dr["Dezoito"].ToString();
								abril.Dezenove = dr["Dezenove"].ToString();
								abril.Vinte = dr["Vinte"].ToString();
								abril.Vinte_Um = dr["Vinte_Um"].ToString();
								abril.Vinte_Dois = dr["Vinte_Dois"].ToString();
								abril.Vinte_Tres = dr["Vinte_Tres"].ToString();
								abril.Vinte_Quatro = dr["Vinte_Quatro"].ToString();
								abril.Vinte_Cinco = dr["Vinte_Cinco"].ToString();
								abril.Vinte_Seis = dr["Vinte_Seis"].ToString();
								abril.Vinte_Sete = dr["Vinte_Sete"].ToString();
								abril.Vinte_Oito = dr["Vinte_Oito"].ToString();
								abril.Vinte_Nove = dr["Vinte_Nove"].ToString();
								abril.Trinta = dr["Trinta"].ToString();
								_abril.Add(abril);
							}
						}
						return _abril;
					}
				}
			}
		}
		public static List<Maio> GetMaio()
		{
			List<Maio> _maio = new List<Maio>();
			using (SqlConnection con = new SqlConnection(GetStringConexao()))
			{
				con.Open();
				using (SqlCommand cmd = new SqlCommand("SELECT * FROM Maio", con))
				{
					using (SqlDataReader dr = cmd.ExecuteReader())
					{
						if (dr != null)
						{
							while (dr.Read())
							{
								var maio = new Maio();
								maio.Um = dr["Dois"].ToString();
								maio.Dois = dr["Um"].ToString();
								maio.Tres = dr["Tres"].ToString();
								maio.Quatro = dr["Quatro"].ToString();
								maio.Cinco = dr["Cinco"].ToString();
								maio.Seis = dr["Seis"].ToString();
								maio.Sete = dr["Sete"].ToString();
								maio.Oito = dr["Oito"].ToString();
								maio.Nove = dr["Nove"].ToString();
								maio.Dez = dr["Dez"].ToString();
								maio.Onze = dr["Onze"].ToString();
								maio.Doze = dr["Doze"].ToString();
								maio.Treze = dr["Treze"].ToString();
								maio.Quatorze = dr["Quatorze"].ToString();
								maio.Quinze = dr["Quinze"].ToString();
								maio.Dezesseis = dr["Dezesseis"].ToString();
								maio.Dezessete = dr["Dezessete"].ToString();
								maio.Dezoito = dr["Dezoito"].ToString();
								maio.Dezenove = dr["Dezenove"].ToString();
								maio.Vinte = dr["Vinte"].ToString();
								maio.Vinte_Um = dr["Vinte_Um"].ToString();
								maio.Vinte_Dois = dr["Vinte_Dois"].ToString();
								maio.Vinte_Tres = dr["Vinte_Tres"].ToString();
								maio.Vinte_Quatro = dr["Vinte_Quatro"].ToString();
								maio.Vinte_Cinco = dr["Vinte_Cinco"].ToString();
								maio.Vinte_Seis = dr["Vinte_Seis"].ToString();
								maio.Vinte_Sete = dr["Vinte_Sete"].ToString();
								maio.Vinte_Oito = dr["Vinte_Oito"].ToString();
								maio.Vinte_Nove = dr["Vinte_Nove"].ToString();
								maio.Trinta = dr["Trinta"].ToString();
								maio.Trinta_Um = dr["Trinta_Um"].ToString();
								_maio.Add(maio);
							}
						}
						return _maio;
					}
				}
			}
		}
		public static List<Junho> GetJunho()
		{
			List<Junho> _junho = new List<Junho>();
			using (SqlConnection con = new SqlConnection(GetStringConexao()))
			{
				con.Open();
				using (SqlCommand cmd = new SqlCommand("SELECT * FROM Junho", con))
				{
					using (SqlDataReader dr = cmd.ExecuteReader())
					{
						if (dr != null)
						{
							while (dr.Read())
							{
								var junho = new Junho();
								junho.Um = dr["Dois"].ToString();
								junho.Dois = dr["Um"].ToString();
								junho.Tres = dr["Tres"].ToString();
								junho.Quatro = dr["Quatro"].ToString();
								junho.Cinco = dr["Cinco"].ToString();
								junho.Seis = dr["Seis"].ToString();
								junho.Sete = dr["Sete"].ToString();
								junho.Oito = dr["Oito"].ToString();
								junho.Nove = dr["Nove"].ToString();
								junho.Dez = dr["Dez"].ToString();
								junho.Onze = dr["Onze"].ToString();
								junho.Doze = dr["Doze"].ToString();
								junho.Treze = dr["Treze"].ToString();
								junho.Quatorze = dr["Quatorze"].ToString();
								junho.Quinze = dr["Quinze"].ToString();
								junho.Dezesseis = dr["Dezesseis"].ToString();
								junho.Dezessete = dr["Dezessete"].ToString();
								junho.Dezoito = dr["Dezoito"].ToString();
								junho.Dezenove = dr["Dezenove"].ToString();
								junho.Vinte = dr["Vinte"].ToString();
								junho.Vinte_Um = dr["Vinte_Um"].ToString();
								junho.Vinte_Dois = dr["Vinte_Dois"].ToString();
								junho.Vinte_Tres = dr["Vinte_Tres"].ToString();
								junho.Vinte_Quatro = dr["Vinte_Quatro"].ToString();
								junho.Vinte_Cinco = dr["Vinte_Cinco"].ToString();
								junho.Vinte_Seis = dr["Vinte_Seis"].ToString();
								junho.Vinte_Sete = dr["Vinte_Sete"].ToString();
								junho.Vinte_Oito = dr["Vinte_Oito"].ToString();
								junho.Vinte_Nove = dr["Vinte_Nove"].ToString();
								junho.Trinta = dr["Trinta"].ToString();
								_junho.Add(junho);
							}
						}
						return _junho;
					}
				}
			}
		}
		public static List<Julho> GetJulho()
		{
			List<Julho> _julho = new List<Julho>();
			using (SqlConnection con = new SqlConnection(GetStringConexao()))
			{
				con.Open();
				using (SqlCommand cmd = new SqlCommand("SELECT * FROM Julho", con))
				{
					using (SqlDataReader dr = cmd.ExecuteReader())
					{
						if (dr != null)
						{
							while (dr.Read())
							{
								var julho = new Julho();
								julho.Um = dr["Dois"].ToString();
								julho.Dois = dr["Um"].ToString();
								julho.Tres = dr["Tres"].ToString();
								julho.Quatro = dr["Quatro"].ToString();
								julho.Cinco = dr["Cinco"].ToString();
								julho.Seis = dr["Seis"].ToString();
								julho.Sete = dr["Sete"].ToString();
								julho.Oito = dr["Oito"].ToString();
								julho.Nove = dr["Nove"].ToString();
								julho.Dez = dr["Dez"].ToString();
								julho.Onze = dr["Onze"].ToString();
								julho.Doze = dr["Doze"].ToString();
								julho.Treze = dr["Treze"].ToString();
								julho.Quatorze = dr["Quatorze"].ToString();
								julho.Quinze = dr["Quinze"].ToString();
								julho.Dezesseis = dr["Dezesseis"].ToString();
								julho.Dezessete = dr["Dezessete"].ToString();
								julho.Dezoito = dr["Dezoito"].ToString();
								julho.Dezenove = dr["Dezenove"].ToString();
								julho.Vinte = dr["Vinte"].ToString();
								julho.Vinte_Um = dr["Vinte_Um"].ToString();
								julho.Vinte_Dois = dr["Vinte_Dois"].ToString();
								julho.Vinte_Tres = dr["Vinte_Tres"].ToString();
								julho.Vinte_Quatro = dr["Vinte_Quatro"].ToString();
								julho.Vinte_Cinco = dr["Vinte_Cinco"].ToString();
								julho.Vinte_Seis = dr["Vinte_Seis"].ToString();
								julho.Vinte_Sete = dr["Vinte_Sete"].ToString();
								julho.Vinte_Oito = dr["Vinte_Oito"].ToString();
								julho.Vinte_Nove = dr["Vinte_Nove"].ToString();
								julho.Trinta = dr["Trinta"].ToString();
								julho.Trinta_Um = dr["Trinta_Um"].ToString();
								_julho.Add(julho);
							}
						}
						return _julho;
					}
				}
			}
		}
		public static List<Agosto> GetAgosto()
		{
			List<Agosto> _agosto = new List<Agosto>();
			using (SqlConnection con = new SqlConnection(GetStringConexao()))
			{
				con.Open();
				using (SqlCommand cmd = new SqlCommand("SELECT * FROM Agosto", con))
				{
					using (SqlDataReader dr = cmd.ExecuteReader())
					{
						if (dr != null)
						{
							while (dr.Read())
							{
								var agosto = new Agosto();
								agosto.Um = dr["Dois"].ToString();
								agosto.Dois = dr["Um"].ToString();
								agosto.Tres = dr["Tres"].ToString();
								agosto.Quatro = dr["Quatro"].ToString();
								agosto.Cinco = dr["Cinco"].ToString();
								agosto.Seis = dr["Seis"].ToString();
								agosto.Sete = dr["Sete"].ToString();
								agosto.Oito = dr["Oito"].ToString();
								agosto.Nove = dr["Nove"].ToString();
								agosto.Dez = dr["Dez"].ToString();
								agosto.Onze = dr["Onze"].ToString();
								agosto.Doze = dr["Doze"].ToString();
								agosto.Treze = dr["Treze"].ToString();
								agosto.Quatorze = dr["Quatorze"].ToString();
								agosto.Quinze = dr["Quinze"].ToString();
								agosto.Dezesseis = dr["Dezesseis"].ToString();
								agosto.Dezessete = dr["Dezessete"].ToString();
								agosto.Dezoito = dr["Dezoito"].ToString();
								agosto.Dezenove = dr["Dezenove"].ToString();
								agosto.Vinte = dr["Vinte"].ToString();
								agosto.Vinte_Um = dr["Vinte_Um"].ToString();
								agosto.Vinte_Dois = dr["Vinte_Dois"].ToString();
								agosto.Vinte_Tres = dr["Vinte_Tres"].ToString();
								agosto.Vinte_Quatro = dr["Vinte_Quatro"].ToString();
								agosto.Vinte_Cinco = dr["Vinte_Cinco"].ToString();
								agosto.Vinte_Seis = dr["Vinte_Seis"].ToString();
								agosto.Vinte_Sete = dr["Vinte_Sete"].ToString();
								agosto.Vinte_Oito = dr["Vinte_Oito"].ToString();
								agosto.Vinte_Nove = dr["Vinte_Nove"].ToString();
								agosto.Trinta = dr["Trinta"].ToString();
								agosto.Trinta_Um = dr["Trinta_Um"].ToString();
								_agosto.Add(agosto);
							}
						}
						return _agosto;
					}
				}
			}
		}
		public static List<Setembro> GetSetembro()
		{
			List<Setembro> _setembro = new List<Setembro>();
			using (SqlConnection con = new SqlConnection(GetStringConexao()))
			{
				con.Open();
				using (SqlCommand cmd = new SqlCommand("SELECT * FROM Setembro", con))
				{
					using (SqlDataReader dr = cmd.ExecuteReader())
					{
						if (dr != null)
						{
							while (dr.Read())
							{
								var setembro = new Setembro();
								setembro.Um = dr["Dois"].ToString();
								setembro.Dois = dr["Um"].ToString();
								setembro.Tres = dr["Tres"].ToString();
								setembro.Quatro = dr["Quatro"].ToString();
								setembro.Cinco = dr["Cinco"].ToString();
								setembro.Seis = dr["Seis"].ToString();
								setembro.Sete = dr["Sete"].ToString();
								setembro.Oito = dr["Oito"].ToString();
								setembro.Nove = dr["Nove"].ToString();
								setembro.Dez = dr["Dez"].ToString();
								setembro.Onze = dr["Onze"].ToString();
								setembro.Doze = dr["Doze"].ToString();
								setembro.Treze = dr["Treze"].ToString();
								setembro.Quatorze = dr["Quatorze"].ToString();
								setembro.Quinze = dr["Quinze"].ToString();
								setembro.Dezesseis = dr["Dezesseis"].ToString();
								setembro.Dezessete = dr["Dezessete"].ToString();
								setembro.Dezoito = dr["Dezoito"].ToString();
								setembro.Dezenove = dr["Dezenove"].ToString();
								setembro.Vinte = dr["Vinte"].ToString();
								setembro.Vinte_Um = dr["Vinte_Um"].ToString();
								setembro.Vinte_Dois = dr["Vinte_Dois"].ToString();
								setembro.Vinte_Tres = dr["Vinte_Tres"].ToString();
								setembro.Vinte_Quatro = dr["Vinte_Quatro"].ToString();
								setembro.Vinte_Cinco = dr["Vinte_Cinco"].ToString();
								setembro.Vinte_Seis = dr["Vinte_Seis"].ToString();
								setembro.Vinte_Sete = dr["Vinte_Sete"].ToString();
								setembro.Vinte_Oito = dr["Vinte_Oito"].ToString();
								setembro.Vinte_Nove = dr["Vinte_Nove"].ToString();
								setembro.Trinta = dr["Trinta"].ToString();
								_setembro.Add(setembro);
							}
						}
						return _setembro;
					}
				}
			}
		}
		public static List<Outubro> GetOutubro()
		{
			List<Outubro> _outubro = new List<Outubro>();
			using (SqlConnection con = new SqlConnection(GetStringConexao()))
			{
				con.Open();
				using (SqlCommand cmd = new SqlCommand("SELECT * FROM Outubro", con))
				{
					using (SqlDataReader dr = cmd.ExecuteReader())
					{
						if (dr != null)
						{
							while (dr.Read())
							{
								var outubro = new Outubro();
								outubro.Um = dr["Dois"].ToString();
								outubro.Dois = dr["Um"].ToString();
								outubro.Tres = dr["Tres"].ToString();
								outubro.Quatro = dr["Quatro"].ToString();
								outubro.Cinco = dr["Cinco"].ToString();
								outubro.Seis = dr["Seis"].ToString();
								outubro.Sete = dr["Sete"].ToString();
								outubro.Oito = dr["Oito"].ToString();
								outubro.Nove = dr["Nove"].ToString();
								outubro.Dez = dr["Dez"].ToString();
								outubro.Onze = dr["Onze"].ToString();
								outubro.Doze = dr["Doze"].ToString();
								outubro.Treze = dr["Treze"].ToString();
								outubro.Quatorze = dr["Quatorze"].ToString();
								outubro.Quinze = dr["Quinze"].ToString();
								outubro.Dezesseis = dr["Dezesseis"].ToString();
								outubro.Dezessete = dr["Dezessete"].ToString();
								outubro.Dezoito = dr["Dezoito"].ToString();
								outubro.Dezenove = dr["Dezenove"].ToString();
								outubro.Vinte = dr["Vinte"].ToString();
								outubro.Vinte_Um = dr["Vinte_Um"].ToString();
								outubro.Vinte_Dois = dr["Vinte_Dois"].ToString();
								outubro.Vinte_Tres = dr["Vinte_Tres"].ToString();
								outubro.Vinte_Quatro = dr["Vinte_Quatro"].ToString();
								outubro.Vinte_Cinco = dr["Vinte_Cinco"].ToString();
								outubro.Vinte_Seis = dr["Vinte_Seis"].ToString();
								outubro.Vinte_Sete = dr["Vinte_Sete"].ToString();
								outubro.Vinte_Oito = dr["Vinte_Oito"].ToString();
								outubro.Vinte_Nove = dr["Vinte_Nove"].ToString();
								outubro.Trinta = dr["Trinta"].ToString();
								outubro.Trinta_Um = dr["Trinta_Um"].ToString();
								_outubro.Add(outubro);
							}
						}
						return _outubro;
					}
				}
			}
		}
		public static List<Novembro> GetNovembro()
		{
			List<Novembro> _novembro = new List<Novembro>();
			using (SqlConnection con = new SqlConnection(GetStringConexao()))
			{
				con.Open();
				using (SqlCommand cmd = new SqlCommand("SELECT * FROM Novembro", con))
				{
					using (SqlDataReader dr = cmd.ExecuteReader())
					{
						if (dr != null)
						{
							while (dr.Read())
							{
								var novembro = new Novembro();
								novembro.Um = dr["Dois"].ToString();
								novembro.Dois = dr["Um"].ToString();
								novembro.Tres = dr["Tres"].ToString();
								novembro.Quatro = dr["Quatro"].ToString();
								novembro.Cinco = dr["Cinco"].ToString();
								novembro.Seis = dr["Seis"].ToString();
								novembro.Sete = dr["Sete"].ToString();
								novembro.Oito = dr["Oito"].ToString();
								novembro.Nove = dr["Nove"].ToString();
								novembro.Dez = dr["Dez"].ToString();
								novembro.Onze = dr["Onze"].ToString();
								novembro.Doze = dr["Doze"].ToString();
								novembro.Treze = dr["Treze"].ToString();
								novembro.Quatorze = dr["Quatorze"].ToString();
								novembro.Quinze = dr["Quinze"].ToString();
								novembro.Dezesseis = dr["Dezesseis"].ToString();
								novembro.Dezessete = dr["Dezessete"].ToString();
								novembro.Dezoito = dr["Dezoito"].ToString();
								novembro.Dezenove = dr["Dezenove"].ToString();
								novembro.Vinte = dr["Vinte"].ToString();
								novembro.Vinte_Um = dr["Vinte_Um"].ToString();
								novembro.Vinte_Dois = dr["Vinte_Dois"].ToString();
								novembro.Vinte_Tres = dr["Vinte_Tres"].ToString();
								novembro.Vinte_Quatro = dr["Vinte_Quatro"].ToString();
								novembro.Vinte_Cinco = dr["Vinte_Cinco"].ToString();
								novembro.Vinte_Seis = dr["Vinte_Seis"].ToString();
								novembro.Vinte_Sete = dr["Vinte_Sete"].ToString();
								novembro.Vinte_Oito = dr["Vinte_Oito"].ToString();
								novembro.Vinte_Nove = dr["Vinte_Nove"].ToString();
								novembro.Trinta = dr["Trinta"].ToString();
								_novembro.Add(novembro);
							}
						}
						return _novembro;
					}
				}
			}
		}
		public static List<Dezembro> GetDezembro()
		{
			List<Dezembro> _dezembro = new List<Dezembro>();
			using (SqlConnection con = new SqlConnection(GetStringConexao()))
			{
				con.Open();
				using (SqlCommand cmd = new SqlCommand("SELECT * FROM Dezembro", con))
				{
					using (SqlDataReader dr = cmd.ExecuteReader())
					{
						if (dr != null)
						{
							while (dr.Read())
							{
								var dezembro = new Dezembro();
								dezembro.Um = dr["Dois"].ToString();
								dezembro.Dois = dr["Um"].ToString();
								dezembro.Tres = dr["Tres"].ToString();
								dezembro.Quatro = dr["Quatro"].ToString();
								dezembro.Cinco = dr["Cinco"].ToString();
								dezembro.Seis = dr["Seis"].ToString();
								dezembro.Sete = dr["Sete"].ToString();
								dezembro.Oito = dr["Oito"].ToString();
								dezembro.Nove = dr["Nove"].ToString();
								dezembro.Dez = dr["Dez"].ToString();
								dezembro.Onze = dr["Onze"].ToString();
								dezembro.Doze = dr["Doze"].ToString();
								dezembro.Treze = dr["Treze"].ToString();
								dezembro.Quatorze = dr["Quatorze"].ToString();
								dezembro.Quinze = dr["Quinze"].ToString();
								dezembro.Dezesseis = dr["Dezesseis"].ToString();
								dezembro.Dezessete = dr["Dezessete"].ToString();
								dezembro.Dezoito = dr["Dezoito"].ToString();
								dezembro.Dezenove = dr["Dezenove"].ToString();
								dezembro.Vinte = dr["Vinte"].ToString();
								dezembro.Vinte_Um = dr["Vinte_Um"].ToString();
								dezembro.Vinte_Dois = dr["Vinte_Dois"].ToString();
								dezembro.Vinte_Tres = dr["Vinte_Tres"].ToString();
								dezembro.Vinte_Quatro = dr["Vinte_Quatro"].ToString();
								dezembro.Vinte_Cinco = dr["Vinte_Cinco"].ToString();
								dezembro.Vinte_Seis = dr["Vinte_Seis"].ToString();
								dezembro.Vinte_Sete = dr["Vinte_Sete"].ToString();
								dezembro.Vinte_Oito = dr["Vinte_Oito"].ToString();
								dezembro.Vinte_Nove = dr["Vinte_Nove"].ToString();
								dezembro.Trinta = dr["Trinta"].ToString();
								dezembro.Trinta_Um = dr["Trinta_Um"].ToString();
								_dezembro.Add(dezembro);
							}
						}
						return _dezembro;
					}
				}
			}
		}

		public static List<Boletim> GetBoletim()
		{
			List<Boletim> _boletim = new List<Boletim>();
			using (SqlConnection con = new SqlConnection(GetStringConexao()))
			{
				con.Open();
				using (SqlCommand cmd = new SqlCommand("SELECT * FROM BOLETIM", con))
				{
					using (SqlDataReader dr = cmd.ExecuteReader())
					{
						if (dr != null)
						{
							while (dr.Read())
							{
								var boletim = new Boletim();
								boletim.ID_Aluno = Convert.ToInt32(dr["ID_Aluno"]);	
								//boletim.Nome = dr["Nome"].ToString();
								boletim.Matematica = Convert.ToDouble(dr["Matematica"]);
								boletim.Portugues = Convert.ToDouble(dr["Portugues"]);
								boletim.Geografia = Convert.ToDouble(dr["Geografia"]);
								boletim.Ingles = Convert.ToDouble(dr["Ingles"]);
								boletim.Fisica = Convert.ToDouble(dr["Fisica"]);
								boletim.Quimica = Convert.ToDouble(dr["Quimica"]);
								boletim.Biologia = Convert.ToDouble(dr["Biologia"]);
								boletim.Artes = Convert.ToDouble(dr["Artes"]);
								boletim.Musica = Convert.ToDouble(dr["Musica"]);
								boletim.EducacaoFisica = Convert.ToDouble(dr["Educacao_Fisica"]);
								boletim.AtividadesComplementares = Convert.ToDouble(dr["Atividades_Complementares"]);
								_boletim.Add(boletim);
							}
						}
						return _boletim;
					}
				}
			}
		}
		public static List<Comunicados> GetComunicados()
		{
			List<Comunicados> _comunicados = new List<Comunicados>();
			using (SqlConnection con = new SqlConnection(GetStringConexao()))
			{
				con.Open();
				using (SqlCommand cmd = new SqlCommand("SELECT * FROM COMUNICADOS", con))
				{
					using (SqlDataReader dr = cmd.ExecuteReader())
					{
						if (dr != null)
						{
							while (dr.Read())
							{
								var comunicados = new Comunicados();
								comunicados.ID_Aluno = Convert.ToInt32(dr["ID_Aluno"]);
								comunicados.Primeira = dr["Primeira"].ToString();
								comunicados.Segunda = dr["Segunda"].ToString();
								comunicados.Terceira = dr["Terceira"].ToString();
								comunicados.Quarta = dr["Quarta"].ToString();
								comunicados.Quinta = dr["Quinta"].ToString();
								comunicados.Sexta = dr["Sexta"].ToString();
								comunicados.Setima = dr["Setima"].ToString();
								comunicados.Oitava = dr["Oitava"].ToString();
								comunicados.Nona = dr["Nona"].ToString();
								_comunicados.Add(comunicados);
							}
						}
						return _comunicados;
					}
				}
			}
		}
		public static List<RoteiroEstudos> GetRoteiroEstudos()
		{
			List<RoteiroEstudos> _roteiroEstudos = new List<RoteiroEstudos>();
			using (SqlConnection con = new SqlConnection(GetStringConexao()))
			{
				con.Open();
				using (SqlCommand cmd = new SqlCommand("SELECT * FROM ROT_ESTUDOS", con))
				{
					using (SqlDataReader dr = cmd.ExecuteReader())
					{
						if (dr != null)
						{
							while (dr.Read())
							{
								var roteiroEstudos = new RoteiroEstudos();
								roteiroEstudos.ID_Aluno = Convert.ToInt32(dr["ID_Aluno"]);
								roteiroEstudos.Primeira = dr["Primeira"].ToString();
								roteiroEstudos.Segunda = dr["Segunda"].ToString();
								roteiroEstudos.Terceira = dr["Terceira"].ToString();
								roteiroEstudos.Quarta = dr["Quarta"].ToString();
								roteiroEstudos.Quinta = dr["Quinta"].ToString();
								roteiroEstudos.Sexta = dr["Sexta"].ToString();
								roteiroEstudos.Setima = dr["Setima"].ToString();
								roteiroEstudos.Oitava = dr["Oitava"].ToString();
								roteiroEstudos.Nona = dr["Nona"].ToString();
								_roteiroEstudos.Add(roteiroEstudos);
							}
						}
						return _roteiroEstudos;
					}
				}
			}
		}
		public static List<ListaMaterial> GetListaMaterial()
		{
			List<ListaMaterial> _listaMaterial = new List<ListaMaterial>();
			using (SqlConnection con = new SqlConnection(GetStringConexao()))
			{
				con.Open();
				using (SqlCommand cmd = new SqlCommand("SELECT * FROM LISTA_MATERIAL", con))
				{
					using (SqlDataReader dr = cmd.ExecuteReader())
					{
						if (dr != null)
						{
							while (dr.Read())
							{
								var listaMaterial = new ListaMaterial();
								listaMaterial.ID_Aluno = Convert.ToInt32(dr["ID_Aluno"]);
								listaMaterial.Primeira = dr["Primeira"].ToString();
								listaMaterial.Segunda = dr["Segunda"].ToString();
								listaMaterial.Terceira = dr["Terceira"].ToString();
								listaMaterial.Quarta = dr["Quarta"].ToString();
								listaMaterial.Quinta = dr["Quinta"].ToString();
								listaMaterial.Sexta = dr["Sexta"].ToString();
								listaMaterial.Setima = dr["Setima"].ToString();
								listaMaterial.Oitava = dr["Oitava"].ToString();
								listaMaterial.Nona = dr["Nona"].ToString();
								_listaMaterial.Add(listaMaterial);
							}
						}
						return _listaMaterial;
					}
				}
			}
		}
		public static List<HoraAula> GetHoraAula()
		{
			List<HoraAula> _horaAula = new List<HoraAula>();
			using (SqlConnection con = new SqlConnection(GetStringConexao()))
			{
				con.Open();
				using (SqlCommand cmd = new SqlCommand("SELECT * FROM HORA_AULA", con))
				{
					using (SqlDataReader dr = cmd.ExecuteReader())
					{
						if (dr != null)
						{
							while (dr.Read())
							{
								var horaAula = new HoraAula();
								horaAula.ID_Aluno = Convert.ToInt32(dr["ID_Aluno"]);
								horaAula.Segunda = dr["Segunda"].ToString();
								horaAula.Terca = dr["Terca"].ToString();
								horaAula.Quarta = dr["Quarta"].ToString();
								horaAula.Quinta = dr["Quinta"].ToString();
								horaAula.Sexta = dr["Sexta"].ToString();
								horaAula.Sabado = dr["Sabado"].ToString();
								_horaAula.Add(horaAula);
							}
						}
						return _horaAula;
					}
				}
			}
		}
		public static List<Reunioes> GetReunioes()
		{
			List<Reunioes> _reunioes = new List<Reunioes>();
			using (SqlConnection con = new SqlConnection(GetStringConexao()))
			{
				con.Open();
				using (SqlCommand cmd = new SqlCommand("SELECT * FROM REUNIOES", con))
				{
					using (SqlDataReader dr = cmd.ExecuteReader())
					{
						if (dr != null)
						{
							while (dr.Read())
							{
								var reunioes = new Reunioes();
								reunioes.ID_Aluno = Convert.ToInt32(dr["ID_Aluno"]);
								reunioes.Nova = dr["Nova"].ToString();
								reunioes.Agendadas = dr["Agendadas"].ToString();
								reunioes.Data_Nova = Convert.ToDateTime(dr["Data_Nova"]);
								reunioes.Data_Agendadas = Convert.ToDateTime(dr["Data_Agendadas"]);
								reunioes.Data_Marcar = Convert.ToDateTime(dr["Data_Marcar"]);
								reunioes.Hora_Nova = Convert.ToDateTime(dr["Hora_Nova"]);
								reunioes.Hora_Agendadas = Convert.ToDateTime(dr["Hora_Agendadas"]);
								reunioes.Hora_Marcar = Convert.ToDateTime(dr["Hora_Marcar"]);
								_reunioes.Add(reunioes);
							}
						}
						return _reunioes;
					}
				}
			}
		}
		public static List<Contato> GetContato()
		{
			List<Contato> _contato = new List<Contato>();
			using (SqlConnection con = new SqlConnection(GetStringConexao()))
			{
				con.Open();
				using (SqlCommand cmd = new SqlCommand("SELECT * FROM CONTATO", con))
				{
					using (SqlDataReader dr = cmd.ExecuteReader())
					{
						if (dr != null)
						{
							while (dr.Read())
							{
								var contato = new Contato();
								contato.TelefoneDiretoria = dr["Telefone_Diretoria"].ToString();
								contato.TelefoneCoordenadoria = dr["Telefone_Coordenadoria"].ToString();
								contato.TelefoneSecretaria = dr["Telefone_Secretaria"].ToString();
								contato.TelefoneFinanceiro = dr["Telefone_Financeiro"].ToString();
								contato.TelefoneProfessora = dr["Telefone_Professora"].ToString();
								contato.EmailDiretoria = dr["Email_Diretoria"].ToString();
								contato.EmailCoordenadoria = dr["Email_Coordenadoria"].ToString();
								contato.EmailSecretaria = dr["Email_Secretaria"].ToString();
								contato.EmailFinanceiro = dr["Email_Financeiro"].ToString();
								contato.EmailProfessora = dr["Email_Professora"].ToString();
								_contato.Add(contato);
							}
						}
						return _contato;
					}
				}
			}
		}

		public static List<Usuarios> GetUsuario()
		{
			List<Usuarios> _usuarios = new List<Usuarios>();
			using (SqlConnection con = new SqlConnection(GetStringConexao()))
			{
				con.Open();
				using (SqlCommand cmd = new SqlCommand("SELECT * FROM USUARIO", con))
				{
					using (SqlDataReader dr = cmd.ExecuteReader())
					{
						if (dr != null)
						{
							while (dr.Read())
							{
								var usuarios = new Usuarios();
								usuarios.UsuarioId = Convert.ToInt32(dr["ID_Aluno"]);
								usuarios.Nome = dr["Nome"].ToString();
								usuarios.Senha = dr["Senha"].ToString();
								_usuarios.Add(usuarios);
							}
						}
						return _usuarios;
					}
				}
			}
		}

		public static int InsertAluno(Aluno aluno)
		{
			int reg = 0;
			using (SqlConnection con = new SqlConnection(GetStringConexao()))
			{
				string sql = "Insert into Aluno(Nome,Idade,Serie,Nome_Mae,Nome_Pai,Nome_Professora,Telefone,Email) " +
	 "values (@Nome, @Idade, @Serie, @Nome_Mae,@Nome_Pai,@Nome_Professora,@Telefone,@Email)";
				using (SqlCommand cmd = new SqlCommand(sql, con))
				{
					cmd.CommandType = CommandType.Text;
					cmd.Parameters.AddWithValue("@nome", aluno.Nome);
					cmd.Parameters.AddWithValue("@Idade", aluno.Idade);
					cmd.Parameters.AddWithValue("@Serie", aluno.Serie);
					cmd.Parameters.AddWithValue("@Nome_Mae", aluno.Nome_Mae);
					cmd.Parameters.AddWithValue("@Nome_Pai", aluno.Nome_Pai);
					cmd.Parameters.AddWithValue("@Nome_Professora", aluno.Nome_Professora);
					cmd.Parameters.AddWithValue("@Telefone", aluno.Telefone);
					cmd.Parameters.AddWithValue("@Email", aluno.Email);

					con.Open();
					reg = cmd.ExecuteNonQuery();
					con.Close();
				}
				return reg;
			}
		}
		public static int UpdateAluno(Aluno aluno)
		{
			int reg = 0;
			using (SqlConnection con = new SqlConnection(GetStringConexao()))
			{
				string sql = "Update Aluno set Nome=@Nome, Idade=@Idade, Serie=@Serie, Nome_Mae=@Nome_Mae " +
	 "Nome_Pai=@Nome_Pai, Nome_Professora=@Nome_Professora, Telefone=@Telefone, Email=@Email " +
	 " Where Nome_Mar = " + aluno.Nome;
				using (SqlCommand cmd = new SqlCommand(sql, con))
				{
					cmd.CommandType = CommandType.Text;
					cmd.Parameters.AddWithValue("@Nome", aluno.Nome);
					cmd.Parameters.AddWithValue("@Idade", aluno.Idade);
					cmd.Parameters.AddWithValue("@Serie", aluno.Serie);
					cmd.Parameters.AddWithValue("@Nome_Mae", aluno.Nome_Mae);
					cmd.Parameters.AddWithValue("@Nome_Pai", aluno.Nome_Pai);
					cmd.Parameters.AddWithValue("@Nome_Professora", aluno.Nome_Professora);
					cmd.Parameters.AddWithValue("@Telefone", aluno.Telefone);
					cmd.Parameters.AddWithValue("@Email", aluno.Email);

					con.Open();
					reg = cmd.ExecuteNonQuery();
					con.Close();
				}
				return reg;
			}
		}
		public static int DeleteAluno(string nome)
		{
			int reg = 0;
			using (SqlConnection con = new SqlConnection(GetStringConexao()))
			{
				string sql = "Delete from Alunos where Nome = " + nome;
				using (SqlCommand cmd = new SqlCommand(sql, con))
				{
					cmd.CommandType = CommandType.Text;
					cmd.Parameters.AddWithValue("@Nome", nome);

					con.Open();
					reg = cmd.ExecuteNonQuery();
					con.Close();
				}
				return reg;
			}
		}


	}
}