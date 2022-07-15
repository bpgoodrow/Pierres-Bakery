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
      Console.WriteLine("Would you like some bread or a pastry?");
      string response = Console.ReadLine();
      if (response == "bread")
      {
        Console.WriteLine("Bread Costs $5 per loaf.");
        Console.WriteLine("However, we currently have a deal: buy 2 loaves of bread get the 3rd free!");
        Console.WriteLine("How many loaves of bread would you like?");
        string breadResponse = int.Parse(Console.ReadLine());
        Bread userBread = new Bread(breadOrder);
      }
    }
  }
}