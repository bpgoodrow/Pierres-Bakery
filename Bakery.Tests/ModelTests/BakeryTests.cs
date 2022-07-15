using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void  BreadCost_CostOneBread_Int()
    {
      int breadQuantity = 1;
      double breadCost = 5;
      Bread breadOrder = new Bread(breadQuantity);
      Assert.AreEqual(breadCost, breadOrder.BreadCost());
    }

    [TestMethod]
    public void BreadCost_CostTwoBread_Int()
    {
      int breadQuantity = 2;
      double breadCost = 10;
      Bread breadOrder = new Bread(breadQuantity);
      Assert.AreEqual(breadCost, breadOrder.BreadCost());
    }

     [TestMethod]
    public void BreadCost_ThirdBreadDiscount_Int()
    {
      int breadQuantity = 3;
      double breadCost = 10;
      Bread breadOrder = new Bread(breadQuantity);
      Assert.AreEqual(breadCost, breadOrder.BreadCost());
    }
  }

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