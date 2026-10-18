namespace Lesson4_homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Temperature temp1 = new Temperature ();
            temp1.Amount = 100;
            temp1.Measure = "Celsius";
            Temperature temp2 = new Temperature();
            temp2.Amount = 212;
            temp2.Measure = "Celsius";
            Console.WriteLine(temp1+temp2);
        }
    }
}
