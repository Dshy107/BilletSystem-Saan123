﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib
{
	public class MC : Køretøjer
	{
		public int Nummerplade { get; set; }
		public DateTime Dato { get; set; }

		public override int Pris()
		{
			return 125;
		}

		public string Køretøj()
		{
			return "MC";
		}
	}
}
