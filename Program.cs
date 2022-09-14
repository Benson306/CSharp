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
            userInput();
            calculator();
            arrays();
        }

        static void userInput(){
            Console.Write("Enter your name: ");
            var name = Console.ReadLine();

            Console.WriteLine("Hi "+name+". Hope you are having a good day");
        }

        static void calculator(){
            Console.Write("Enter First Number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Second Number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("The sum is: "+(num1 + num2));
        }

        
        static void arrays(){
            int [] luckyNumbers = {22, 10, 8, 43, 54};
            Console.WriteLine(luckyNumbers[0]);

            string[] friends = new string[3];
            friends[0] = "Benji";

            sayHi("benji");
        }

        
        static void sayHi(string name){
            Console.WriteLine("Hello "+name);
        }
    }
}
