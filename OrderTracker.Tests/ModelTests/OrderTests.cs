using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using OrderTracker.Models;
using System;

namespace OrderTracker.TestTools
{
  [TestClass]
  public class OrderTests 
  {

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("testTitle", "testDescription", 10, "testDate");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
  }
}