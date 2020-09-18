
namespace workshop_app.Models {
   class Mango : Fruit {
      public override void BakeInPie() {
         //make a mango pie here          
      }

      public Mango(int weight, bool isEdible) {
         Name = "Mango";
         Weight = weight;
         IsEdible = isEdible;
         IsToxic = !isEdible;
      }
   }
}
