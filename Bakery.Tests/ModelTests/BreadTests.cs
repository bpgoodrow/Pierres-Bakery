using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Bakery.Models;

namespace BreadTests.Tests
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
}