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
            // byte number=10;

            int count = 10;
            float totalPrice = 20.95f;
            char character = 'A';
            bool isLoading = true;


            var number= 22;

            const float pi =  3.142f;

            var area = pi * 5;

            System.Console.WriteLine("The area is: "+area);
            Console.WriteLine(number);
            System.Console.WriteLine("ben");

        }

        static void typeConversion(){
            // ToByte();
            // ToInt16();
            // ToInt32();
            // ToInt64();

            string s = "167";
                int i = int.Parse(s);
                System.Console.WriteLine(i);

            try
            {
                var num = "1234";
                byte b = Convert.ToByte(num);
                Console.WriteLine(b);
            }
            catch (System.Exception)
            {
                Console.WriteLine("The number could not be converted to a byte.");
            }
            
        }
        static void Main(string[] args)
        {
            age(2010.11m, 2020.31m);
            newMethod();
            typeConversion();
        }
        
    }
}
