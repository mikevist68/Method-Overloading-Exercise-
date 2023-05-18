namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            
            //Add(2.5, 2.5);
            //var addBool = Add(0, 1, false );
            //Console.WriteLine( addBool );
            Console.WriteLine(Add(2, 2));
            Console.WriteLine(Add(2.5, 2.5));
            Console.WriteLine(Add(2, 2, true));

        }
        public static int Add(int num1, int num2)
        { 
            return num1 + num2;
            Console.WriteLine($"{num1} and {num2} =");
        }

        public static double Add(double num1, double num2)
        {
            return num1 + num2;
        }
   
        public static string Add(int num1, int num2, bool ischecked )
        {
            var sum = num1 + num2;

            if (ischecked == true && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (ischecked == true && sum == 1)
            {
                return $"{sum} dollar";
            }
            else 
            {
                return $"{sum}";

            }
            
        
        }   
    
    }


}





           