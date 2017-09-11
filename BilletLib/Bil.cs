using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib
{
    public class Bil : Køretøjer
    {
        /// <summary>
        /// For at tilpasse Bil klassen til base klassen, skal Nummerplade og Dato væk, da de skal være i base klassen.
        /// </summary>
		public string Nummerplade { get; set; }
		public DateTime Dato { get; set; }

		public override int Pris()
		{
			return 240;
		}

		public string Køretøj()
		{
			return "bil";
		}

	}
}
