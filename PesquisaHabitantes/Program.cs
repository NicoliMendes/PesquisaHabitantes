using System;
using System.Collections.Generic;
using System.Globalization;

namespace PesquisaHabitantes
{
	class Program
	{
		public static int NumHabitantes = 0;
		public static List<Habitantes> Habitante = new List<Habitantes>();

		static void Main(string[] args)
		{
			Console.Write("PESQUISA DE HABITANTES\n\n");
			Cadastrar();
		}
		public static void Cadastrar()
		{
			double SomaSalario = 0;
			double MaiorSalario = 0;
			double Salarios150 = 0;
			double SomaFilhos = 0;

			NumHabitantes = VerificaInt("Numero de habitantes");

			for (int i = 0; i < NumHabitantes; i++)
			{
				Habitantes hab = new Habitantes();
				hab.Nome = VerificaString("Nome");
				hab.Salario = VerificaDouble("Salario");
				hab.Dependentes = VerificaInt("Dependentes");
				hab.CPF = VerificaString("CPF");
				hab.Idade = VerificaInt("Idade");
				hab.Endereco = VerificaString("Endereço");
				hab.NomePai = VerificaString("Nome do Pai");
				hab.NomeMae = VerificaString("Nome da Mae");
				hab.TipoSangue = VerificaString("Tipo Sanguineo");

				SomaSalario += hab.Salario;

				if (hab.Salario > MaiorSalario)
				{
					MaiorSalario = hab.Salario;
				}
				if (hab.Salario <= 150.0)
				{
					Salarios150++;
				}

				SomaFilhos += hab.Dependentes;

				Habitante.Add(hab);
			};

			double MediaSalario = 0;
			int SomaHabitantes = Habitante.Count;
			MediaSalario = SomaSalario / SomaHabitantes;
			Console.Write("\n==================================================");
			Console.Write("\nMédia dos salários: ");
			Console.Write(MediaSalario.ToString("C", CultureInfo.CurrentCulture));

			double mediaFilhos;
			mediaFilhos = SomaFilhos / NumHabitantes;
			Console.Write($"\nMédia dos filhos: {mediaFilhos}");

			Console.Write("\nMaior dos salários: ");
			Console.Write(MaiorSalario.ToString("C", CultureInfo.CurrentCulture));

			double percSalario = 0;
			percSalario = (Salarios150 / NumHabitantes) * 100;
			Console.Write($"\nPercentual de salários <= R$ 150: {percSalario} %");
			Console.Write("\n==================================================");

			Listar(NumHabitantes);
		}

		public static void Listar(int NumHabitantes)
		{
			Console.Write("\nLista de Habitantes Pesquisados");
			Console.Write("\n==================================================");
			Habitante.ForEach(item =>
			{
				Console.Write($"\n\nNome: {item.Nome}\nSalário: {item.Salario}\nDependentes: {item.Dependentes}");
			});
		}

		public static string VerificaString(string Campo)
		{

			Console.Write($"Digite o {Campo}: ");

			string result = "";
			do
			{
				result = Console.ReadLine();

			} while (result == "");

			return result;
		}

		public static double VerificaDouble(string Campo)
		{
			Console.Write($"Digite o {Campo}: ");
			double result = 0.0;
			bool VerificaDouble = false;
			do
			{
				try
				{
					result = Convert.ToDouble(Console.ReadLine());
					VerificaDouble = true;
				}
				catch
				{
					Console.Write("\nValor inválido! Digite novamente: ");
				}

			} while (!VerificaDouble);

			return result;
		}

		public static int VerificaInt(string Campo)
		{
			Console.Write($"Digite o {Campo}: ");
			int result = 0;
			bool VerificaInt = false;
			do
			{
				try
				{
					result = Convert.ToInt32(Console.ReadLine());
					VerificaInt = true;
				}
				catch
				{
					Console.Write("\nValor inválido! Digite novamente: ");
				}

			} while (!VerificaInt);

			return result;
		}
	}

	public class Habitantes
	{
		public string Nome { get; set; }
		public double Salario { get; set; }
		public int Dependentes { get; set; }
		public string CPF { get; set; }
		public int Idade { get; set; }
		public string Endereco { get; set; }
		public string EstadoCivil { get; set; }
		public string NomePai { get; set; }
		public string NomeMae { get; set; }
		public string TipoSangue { get; set; }
	}
}using System;

namespace PesquisaHabitantes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
