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
            // age(2010.11m, 2020.31m);
            // newMethod();
            // typeConversion();
            // userInput();
            // calculator();
            // arrays();
            // int num = cube(4);

            // Console.WriteLine(num+" is the cube of 4");

            // Console.WriteLine("The maximum number is: "+GetMax(3,5,7));

            // Console.Write(switchStatement(17));

            // whileLoops();

            forLoops();
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

        //return method

        static int cube(int number){

            int cube =  number * number * number;
            return cube;
        }

        static void ifStatements(){
            bool isMale = true;
            if(isMale){
                Console.WriteLine("You are Male");
            }else{
                Console.WriteLine("You are not Male");
            }
        }

        static int GetMax(int num1, int num2, int num3){
            int result;
            
            if(num1 >= num2 && num1 >= num3){
                result = num1;
            }else if(num2 >= num3){
                result = num2;
            }else{
                result = num3;
            }

            return result;
        }

        static string switchStatement(int dayNum){
            string  dayName;

            switch(dayNum){
                case 1:
                    dayName = "Sunday";
                    break;
                case 2:
                    dayName = "Monday";
                    break;
                case 3:
                    dayName = "Tuesday";
                    break;
                case 4:
                    dayName = "Wednesday";
                    break;
                case 5:
                    dayName = "Thursday";
                    break;
                case 6:
                    dayName = "Friday";
                    break;
                case 7:
                    dayName = "saturday";
                    break;
                default:
                    dayName = "Not a day of the week";
                    break;
            }

            return dayName;
        }

        static void whileLoops(){
            int result=5;
             
             while(result < 10){
                 Console.WriteLine(result);
                 result += 1;
             }
        }

        static void forLoops(){
            for(int i =1; i<10; i++){
                Console.WriteLine(i);
            }
        }

        
    }
}
