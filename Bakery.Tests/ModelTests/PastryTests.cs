using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Bakery.Models;

namespace PastryTests.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryCost_CostOnePastry_Int()
    {
      int pastryQuantity = 1;
      int pastryCost = 2;
      Pastry pastryOrder = new Pastry(pastryQuantity);
      Assert.AreEqual(pastryCost, pastryOrder.PastryCost());
    }

    [TestMethod]
    public void PastryCost_CostTwoPastry_Int()
    {
      int pastryQuantity = 2;
      int pastryCost = 4;
      Pastry pastryOrder = new Pastry(pastryQuantity);
      Assert.AreEqual(pastryCost, pastryOrder.PastryCost());
    }

    [TestMethod]
    public void PastryCost_ThirdPastryDiscount_Int()
    {
      int pastryQuantity = 3;
      int pastryCost = 5;
      Pastry pastryOrder = new Pastry(pastryQuantity);
      Assert.AreEqual(pastryCost, pastryOrder.PastryCost());
    }
  }
}