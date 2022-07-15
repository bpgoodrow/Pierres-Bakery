using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Bakery.Models;

namespace CakeTests.Tests
{
  [TestClass]
  public class CakeTests
  {
    [TestMethod]
    public void CakeCost_OneCake_Int()
    {
      int cakeQuantity = 1;
      int cakeCost = 25;
      Cake cakeOrder = new Cake(cakeQuantity);
      Assert.AreEqual(cakeCost, cakeOrder.CakeCost());
    }

    [TestMethod]
    public void CakeCost_TwoCake_Int()
    {
      int cakeQuantity = 2;
      int cakeCost = 50;
      Cake cakeOrder = new Cake(cakeQuantity);
      Assert.AreEqual(cakeCost, cakeOrder.CakeCost());
    }
  }
}