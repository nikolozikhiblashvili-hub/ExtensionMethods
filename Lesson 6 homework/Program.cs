namespace Lesson_6_homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 20, 30, 40, 50 };
            string name = "hello";

            
            Console.WriteLine("Reverse:");
            numbers.PrintReverse();

            
            Console.WriteLine("\nFirst element:");
            Console.WriteLine(numbers.GetFirstElemnt());


            Console.WriteLine("\nUppercase:");
            name.PrintUpper();
           

            Console.WriteLine("\nContains element:");
            Console.WriteLine(numbers.ContainsElement(30)); 
            Console.WriteLine(numbers.ContainsElement(99)); 

            
            Console.WriteLine("\nCount:");
            Console.WriteLine(numbers.CountElemts()); 

          
            Console.WriteLine("\nFind index:");
            Console.WriteLine(numbers.FindIndex(40)); 
            Console.WriteLine(numbers.FindIndex(90)); 
        }
    }
}
