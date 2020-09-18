using System;
using workshop_app.Models;

namespace workshop_app {
   class Program {
      
      private static void Main(string[] args) {         
         Console.WriteLine("Hello!\n");

         Banana bananaFruit = new Banana(130, true, EState.Fresh);
         Mango mangoFruit = new Mango(300, true);

         ExposeFruit(bananaFruit);
         ExposeFruit(mangoFruit);         

         Console.WriteLine("\nDone!");
         Console.ReadLine();
      }      

      /// <summary>
      /// Writes down fruit properties, behaves differently for different fruits
      /// </summary>
      /// <param name="fruit">The fruit.</param>
      private static void ExposeFruit(IFruit fruit) {
         Console.WriteLine($"Our fruit is a {fruit.Name}");
         Console.WriteLine("Is our fruit toxic?");
         Console.WriteLine(fruit.IsToxic);
         if (fruit is Banana) {
            Console.WriteLine("What is the status of the fruit?");
            Console.WriteLine(((Banana) fruit).State );
         }
         Console.WriteLine("How many grams does our fruit weigh?");
         Console.WriteLine(fruit.Weight);
         Console.WriteLine("\n Analysis complete \n");
      }
   }
}
