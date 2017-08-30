using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilletLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib.Tests
{
	[TestClass()]
	public class BilTests
	{
		[TestMethod()]
		public void PrisTestbil()
		{
			//Arrange
			var Bil = new Bil();

			//Act
			int pris = Bil.Pris();

			//Assert
			Assert.AreEqual(240, pris);

		}

		[TestMethod()]
		public void KøretøjTestbil()
		{
			//Arrange
			var Bil = new Bil();

			//Act
			string køretøj = Bil.Køretøj();

			//Assert
			Assert.AreEqual("bil", køretøj);
		}
	}
}