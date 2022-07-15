using System;

namespace Bakery.Models
{
  public class Bread
  {
    private static int _Price = 5;
    private int _Discount;
    public int Quantity { get; set; }

    public static int Price
    {
      get { return _Price; }
      set { _Price = value; }
    }

    public Bread(int quantity)
    {
      _Price = Price;
      _Discount = 0;
      Quantity = quantity;
    }

    public int BreadCost()
    {
      int breadTotal = 0;
      for (int index = 0; index <= Quantity; index++)
      {
        if (index == 0)
        {
          breadTotal += 0;
        }
        else if (index % 3 == 0)
        {
          breadTotal += _Price * _Discount;
        }
        else
        {
          breadTotal += _Price;
        }
      }
      return breadTotal;
    }
  }

  public class Pastry
  {
    private static double _Price = 2;
    private double _Discount;
    public int Quantity { get; set; }

    public static double Price
    {
      get { return _Price; }
      set { _Price = value; }
    }

    public Pastry(int quantity)
    {
      _Price = Price;
      _Discount = .5;
      Quantity = quantity;
    }

    public double PastryCost()
    {
      double PastryTotal = 0;
      for (int index = 0; index <= Quantity; index++)
      {
        if (index == 0)
        {
          PastryTotal += 0;
        }
        else if (index % 3 == 0)
        {
          PastryTotal += _Price * _Discount;
        }
        else
        {
          PastryTotal += _Price;
        }
      }
      return PastryTotal;
    }
  }

  public class Cake
  {
    private static int _Price = 25;
    public int Quantity { get; set; }

    public static int Price
    {
      get { return _Price; }
      set { _Price = value; }
    }

    public Cake(int quantity)
    {
      _Price = Price;
      Quantity = quantity;
    }

    public int CakeCost()
    {
      int CakeTotal = 0;
      for (int index = 0; index <= Quantity; index++)
      if (index == 0)
      {
        CakeTotal += 0;
      }
      else
      {
        CakeTotal += _Price;
      }
    return CakeTotal;
    }
  }
}