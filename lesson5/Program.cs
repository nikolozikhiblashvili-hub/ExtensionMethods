using System.Security.Cryptography.X509Certificates;

namespace lesson5
{
    internal class Program
    {
        static void Main(string[] args)
        {

           //List<int> numbers = new List<int>() { 20,33,44,30};
           // List<int> numi = new List<int>();
           // numi.Add(30);
           // numi.AddRange(numbers);
           // numi.Remove(33);
           // foreach (var item in numi)
           // {
           //     Console.WriteLine(item);
           // }
           // while (numi.Contains(30))
           // {
           //     numi.Remove(30);
           // }
           // for(int i = 0; i < numi.Count; i++)
           // {
           //     Console.WriteLine(numi[i]);
           // }
           // numi.Sort();
           // numi.TrimExcess();
           ////

            //HashSet<int> numset = new() { 20, 33, 44, 30 };

            ///
            //Queue<string> queue = new Queue<string>();
            //queue.Enqueue("koksa");
            //queue.Enqueue("kaksa");
            //Console.WriteLine(queue.Peek());
            //queue.Dequeue();
            ///

            //L I F O
            //Stack<string> stack = new Stack<string>();
            //stack.Push("koksa");
            //stack.Push("kaksa");
            //Console.WriteLine(stack.Peek());
            //stack.Pop();
            //Console.WriteLine(stack.Peek());

            ///
            //    public static int Powerer(int num, int pow)
            //{
            //    if (pow == 1)
            //    {
            //        return num;
            //    }
            //    return num * Powerer(num, pow - 1);
            //}\

            // End of Main's code


            // Main currently has no executable code


         public static int Factorial(int num)
         {
            if (num == 1)
            {
                return 1;
            }
             return num * Factorial(num - 1);
         }

       
    }
}
