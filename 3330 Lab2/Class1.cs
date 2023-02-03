namespace Task5
{
public class Class1
{
    public static double Pow(double num1,double num2)
    {
            double result_one;
            result_one = Math.Pow(num1, num2);

            Console.WriteLine("{0} to the power of {1} is: {2}", num1, num2, Math.Pow(num1, num2));
            return result_one;
        }

    public static double Pow1(double result_1, double num3)
    {
            double result_two;
            result_two = Math.Pow(result_1, num3);

            Console.WriteLine("{0} to the power of {1} is: {3} ", result_1, num3, Math.Pow(result_1, num3));
            return result_two;
        }
}
}