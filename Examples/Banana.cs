//  --------------------------------------------------------------------------------------------
//  <Copyright>
//      Copyright © 2004 - 2017 Stabiplan bv. / Stabiplan International bv. All rights reserved.
//  </Copyright>
//  --------------------------------------------------------------------------------------------

namespace workshop_app.Models {
   class Banana : Fruit {
      public override void BakeInPie() {
         //make a banana pie here
      }

      #region Constructors

      public Banana(int weight, bool isEdible, EState state) {
         Name = "Banana";
         Weight = weight;
         IsEdible = isEdible;
         IsToxic = !isEdible;
         State = state;
      }

      #endregion

      #region Properties

      public EState State { get; set; }

      #endregion

      #region Methods - Public

      public override bool Equals(object obj) {
         if (ReferenceEquals(null, obj)) return false;
         if (ReferenceEquals(this, obj)) return true;
         if (obj.GetType() != this.GetType()) return false;
         return Equals((Banana) obj);
      }

      public override int GetHashCode() {
         return (int) State + Weight;
      }

      public static object operator +(Banana b1, Banana b2) {
         EState bananaState = EState.Unknown;

         if (b1.State == b2.State) {
            bananaState = b1.State;
         }

         return new Banana(b1.Weight + b2.Weight, b1.IsEdible.Equals(b2.IsEdible), bananaState);
      }

      public static bool operator ==(Banana banana, IFruit fruit) {
         if (banana == null && fruit == null) {
            return true;
         }

         if (banana != null && fruit != null) {
            return banana.Weight == fruit.Weight && banana.IsEdible.Equals(fruit.IsEdible) && banana.IsToxic.Equals(fruit.IsToxic);
         }

         //one of the bananas is null
         return false;
      }

      public static bool operator !=(Banana f1, IFruit f2) {
         return !(f1 == f2);
      }

      #endregion

      #region Methods - Protected

      protected bool Equals(Banana other) {
         if (other == null) {
            return false;
         }
         return Weight == other.Weight && IsEdible == other.IsEdible && State == other.State;
      }      

      #endregion
   }
}