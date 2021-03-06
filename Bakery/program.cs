using System;
using System.Collections.Generic;
using System.Linq;
using Bakery.Models;

namespace Bakery.Models
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("Would you like some bread or a pastry or a cake?");
      string response = Console.ReadLine();
      if (response == "bread")
      {
        Console.WriteLine("Bread Costs $" + Bread.Price + " per loaf.");
        Console.WriteLine("However, we currently have a deal: buy 2 loaves of bread get the 3rd free!");
        Console.WriteLine("How many loaves of bread would you like?");
        int breadOrder = int.Parse(Console.ReadLine());
        Bread userBread = new Bread(breadOrder);
        Console.WriteLine("For " + userBread.Quantity + " loaves of bread your total is $" + userBread.BreadCost());
        Console.WriteLine("Thanks for coming to Pierre's Bakery!");
      }
      else if (response == "pastry")
      {
        Console.WriteLine("Pastries cost $" + Pastry.Price + " per pastry.");
        Console.WriteLine("However, we currently have a deal: buy 2 pastries get the 3rd pastry half off!");
        Console.WriteLine("How many pastries would you like?");
        int pastryOrder = int.Parse(Console.ReadLine());
        Pastry userPastry = new Pastry(pastryOrder);
        Console.WriteLine("For " + userPastry.Quantity + " pastries your total is $" + userPastry.PastryCost());
        Console.WriteLine("Thanks for coming to Pierre's Bakery!");
      }
      else if (response == "cake")
      {
        Console.WriteLine("Cakes cost $" + Cake.Price + " per cake.");
        Console.WriteLine("No discounts on cakes today!");
        Console.WriteLine("How many cakes would you like?");
        int cakeOrder = int.Parse(Console.ReadLine());
        Cake userCake = new Cake(cakeOrder);
        Console.WriteLine("For " + userCake.Quantity + " cake(s) your total is $" + userCake.CakeCost());
        Console.WriteLine("Thanks for coming to Pierre's Bakery!");
      }
      else
      {
        Main();
      }
    }
  }
}