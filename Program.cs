using System;

namespace hello
{
    class Program
    {
        static void age(decimal year, decimal curr){
            decimal ege = curr-year;
            if(ege > 10){
                Console.WriteLine("Your age is "+ege+".You are allowed to drink");
            }else{
                Console.WriteLine("Your age is "+ege+".Study Hard");
            }
            
        }

        static void newMethod(){
            byte number=10;

            int count = 10;
            float totalPrice = 20.95f;
            char character = 'A';
            bool isLoading = true;
            
            Console.WriteLine(number);
        }
        static void Main(string[] args)
        {
            age(2010.11m, 2020.31m);
            newMethod();
        }
        
    }
}
