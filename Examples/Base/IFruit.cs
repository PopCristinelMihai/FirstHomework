
namespace workshop_app.Models {
   interface IFruit {
      string Name { get; set; }
      bool IsToxic { get; set; }
      bool IsEdible { get; set; }
      int Weight { get; set; }

      void BakeInPie();

   }
}
