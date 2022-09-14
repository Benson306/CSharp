using System;
namespace hello
{
    class ItalianChef : Chef //inherits chef class
    {
        public override void MakeSpecialDish(){ //virtual to override
          Console.WriteLine("The chef makes chicken parm");
        }
        public void MakePasta(){
            Console.WriteLine("The Chef Makes Pasta");
        }

    }
}