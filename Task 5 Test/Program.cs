using System.Threading.Tasks;

namespace TestTask
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, num3, result_one, result_two;
            
            
                Console.WriteLine("Please enter your first number: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please enter your second number: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please enter your third number: ");
                num3 = Convert.ToDouble(Console.ReadLine());


            result_one = Task5.Class1.Pow(num1, num2);
            result_two = Task5.Class1.Pow(result_one, num3);


        }
    }
}