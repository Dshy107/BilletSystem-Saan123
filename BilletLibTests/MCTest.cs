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
	public class MCTests
	{
		[TestMethod()]
		public void PrisTestMC()
		{
			//Arrange
			var MC = new MC();

			//Act
			int pris = MC.Pris();

			//Assert
			Assert.AreEqual(125, pris);

		}

		[TestMethod()]
		public void KøretøjTestMC()
		{
			//Arrange
			var MC = new MC();

			//Act
			string køretøj = MC.Køretøj();

			//Assert
			Assert.AreEqual("MC", køretøj);
		}
	}
}