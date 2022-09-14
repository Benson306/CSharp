using System;

namespace hello
{
    class Chef
    {
      public void MakeChicken(){
          Console.WriteLine("The chef makes chicken");
      }
      public void MakeSalad(){
          Console.WriteLine("The chef makes salad");
      }
      public virtual void MakeSpecialDish(){ //virtual to override
          Console.WriteLine("The chef makes bbq ribs");
      }
    }
}