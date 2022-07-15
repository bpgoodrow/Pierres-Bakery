using System;

namespace Bakery.Models
{
  public class Bakery
  {
    private static double Price = 5;
    public int Quantity { get; }

    public Bread(int quantity)
    {
      _price = Price;
      Quantity = quantity;
    }

    public double breadCost(breadOrder)
    {
      double breadTotal = 0;
      for (int index = 0; index <= Quantity; index++)
      {
        if (index == 0)
        {
          breadTotal += 0;
        }
        else
        {
          {
            breadTotal += _price;
          }
        }
      }
      return breadTotal;
    }
  }
}