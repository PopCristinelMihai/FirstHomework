
using workshop_app.Models.Enums;


namespace workshop_app.Models {
   class Pie {

      public Pie(Fruit fruit) {
         if (fruit is Banana) {
            Type = EPieType.Banana;
         }else if (fruit is Mango) {
            Type = EPieType.Mango;
         } else {
            Type = EPieType.Simple;
         }
      }

      public EPieType Type { get; set; }

      public int Rating { get; set; }

   }
}
