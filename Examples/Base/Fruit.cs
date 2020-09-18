
using System.CodeDom;


namespace workshop_app.Models {
   abstract class Fruit : IFruit {
      public string Name { get; set; }
      public bool IsToxic { get; set; }
      public bool IsEdible { get; set; }
      public int Weight { get; set; }

      public virtual void BakeInPie() {
      }
   }
}
