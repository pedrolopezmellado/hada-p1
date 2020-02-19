using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hada_p1
{
	class HadaP1
	{
		public static double Seconds2Minutes(double s) // este método pasa de segundos a minutos
		{
			if (s == 0) // si es 0 devuelve directamente 0
			{
				return 0;
			}
			else
			{
				return s / 60.0; // divide entre 60
			}
		} // 

		public static double Minutes2Seconds(double m) // este método pasa de minutos a segundos
		{
			return m * 60; // multiplica por 60
		}
	}
}
