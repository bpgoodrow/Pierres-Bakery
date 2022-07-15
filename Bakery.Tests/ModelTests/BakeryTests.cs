using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [Test Method]
    public void BreadCost_CostOneBread_Int()
    {
      int breadQuantitiy = 1;
      double breadCost = 5;
      Bread breadOrder = new Bread(breadQuantitiy);
      Assert.AreEqual(breadCost, breadOrder.breadCost());
    }
  }
  [TestClass]
  public class PastryTests
  {
    [Test Method]
    public void PastryCost_CostOnePastry_Int();
    {
      int pastryQuantity = 1;
      double pastryCost = 2;
      Pastry pastryOrder = new Pastry(pastryQuantity);
      Assert.AreEqual(pastryCost, pastryOrder.PastryCost());
    }
  }
}