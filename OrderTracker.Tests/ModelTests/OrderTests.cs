using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using OrderTracker.Models;
using System;

namespace OrderTracker.TestTools
{
  [TestClass]
  public class OrderTests : IDisposable
  {

    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("testTitle", "testDescription", 10, "testDate");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetOrderTitle_ReturnsOrderTitle_String()
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
    public void GetOrderDescription_ReturnsOrderDescription_String()
    {
      string orderTitle = "testTitle";
      string orderDescription = "testDescription";
      int orderPrice = 10;
      string orderDate = "testDate";
      Order newOrder = new Order(orderTitle, orderDescription, orderPrice, orderDate);
      string resultDescription = newOrder.OrderDescription;
      Assert.AreEqual(orderDescription, resultDescription);
    }

    [TestMethod]
    public void GetOrderPrice_ReturnsOrderPrice_Int()
    {
      string orderTitle = "testTitle";
      string orderDescription = "testDescription";
      int orderPrice = 10;
      string orderDate = "testDate";
      Order newOrder = new Order(orderTitle, orderDescription, orderPrice, orderDate);
      int resultPrice = newOrder.OrderPrice;
      Assert.AreEqual(orderPrice, resultPrice);
    }

    [TestMethod]
    public void GetOrderDate_ReturnsOrderDate_String()
    {
      string orderTitle = "testTitle";
      string orderDescription = "testDescription";
      int orderPrice = 10;
      string orderDate = "testDate";
      Order newOrder = new Order(orderTitle, orderDescription, orderPrice, orderDate);
      string resultDate = newOrder.OrderDate;
      Assert.AreEqual(orderDate, resultDate);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new List<Order> { };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
  }
}