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

    [TestMethod]
    public void GetTitle_ReturnsOrderTitle_String()
    {
      string orderTitle = "testTitle";
      string orderDescription = "testDescription";
      int orderPrice = 10;
      string orderDate = "testDate";
      Order newOrder = new Order(orderTitle, orderDescription, orderPrice, orderDate);
      string resultTitle = newOrder.OrderTitle;
      Assert.AreEqual(orderTitle, resultTitle);
    }

    [TestMethod]
    public void GetTitle_ReturnsOrderDescription_String()
    {
      string orderTitle = "testTitle";
      string orderDescription = "testDescription";
      int orderPrice = 10;
      string orderDate = "testDate";
      Order newOrder = new Order(orderTitle, orderDescription, orderPrice, orderDate);
      string resultDescription = newOrder.OrderDescription;
      Assert.AreEqual(orderDescription, resultDescription);
    }
  }
}