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
}