using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szamologep
{
	internal class Program
	{

		static float szam1 = 0;
		static float szam2 = 0;
		static string jel = "";

		static void Main(string[] args)
		{
			Indit();

		}
		static void Indit()
		{
			Console.Write("Addj meg egy számot: ");
			szam1 = float.Parse(Console.ReadLine());
			Console.Write("Addj meg egy másik számot: ");
			szam2 = float.Parse(Console.ReadLine());
			Console.Write("Addj meg egy másik számot: ");
			jel = Convert.ToString(Console.ReadLine());

			switch (jel)
			{
				case "+":
					Osszeadas();
					break;
				case "-":
					Kivonas();
					break;
				case "/":
					Osztas(); 
					break;
				case "*":
					Szorzas();
					break;
			}
		}

		static void Osszeadas()
		{
			float ossz = szam1 + szam2;
			Console.WriteLine($"Két szám összeadava: {ossz}");
		}
		static void Kivonas()
		{
			float kivon = szam1 - szam2;
			Console.WriteLine($"Két szám kivonva egymásból: {kivon}");
		}
		static void Osztas()
		{
			float oszt = szam1 / szam2;
			Console.WriteLine($"Két szám hányadosa: {oszt}");
		}
		static void Szorzas()
		{
			float szor = szam1 * szam2;
			Console.WriteLine($"Két szám szorzata: {szor}");
		}
	}
}
