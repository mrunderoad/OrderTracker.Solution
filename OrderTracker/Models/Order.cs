using System.Collections.Generic;
using System;

namespace OrderTracker.Models
{
  public class Order
  {
    public string OrderTitle { get; set; }
    public string OrderDescription { get; set; }
    public int OrderPrice { get; set; }
    public string OrderDate { get; set; } 
    private static List<Order> _orders = new List<Order> {};

    public Order()
    {
      
    }
  }
}