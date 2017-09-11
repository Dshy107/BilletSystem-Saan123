using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib
{
	public abstract class Køretøjer
	{
		public abstract int Pris();
        /// <summary>
        /// Base klassen mangler nogle metoder til at virke, som for et eksempel Dato og Nummerplade til en start.
        /// </summary>
        /// <returns></returns>
		public virtual string køretøjer()
		{

		}

	}
}
