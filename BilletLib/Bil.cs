﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib
{
    public class Bil : Køretøjer
    {
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
