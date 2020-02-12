using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hada_p1
{
	class Program
	{
		static void Main(string[] args)
		{
			do
			{

				string men;
				System.Console.WriteLine("De que unidad partes? (s/m)");
				men = System.Console.ReadLine();
				System.Console.WriteLine("Cantidad: ");
				string cant = System.Console.ReadLine();
				double tiempo = System.Double.Parse(cant);
				double sol = 0.0;
				if (men == "s")
				{
					sol = HadaP1.Seconds2Minutes(tiempo);
					System.Console.WriteLine("Tiempo de segundos a minutos: " + sol + "\n");
				}
				else if (men == "m")
				{
					sol = HadaP1.Minutes2Seconds(tiempo);
					System.Console.WriteLine("Tiempo de minutos a segundos: " + sol + "\n");
				}
				System.Console.WriteLine("Quiere realizar más conversiones? (s/n)");
			} while (System.Console.ReadLine() == "s");
		}
	}
}
