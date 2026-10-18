namespace Lesson7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var firstElement= ArrayHelper.GetFirstElemnt([33,44,55])

            //int[] numbers = [1, 2, 3, 4, 5];
            //numbers.PrintReverse();

            //string[] words = ("apple" );
            //words.PrintUpper();

            Users[] users = new Users[]
            {
                new Users { Name = "John", Password = "password1" },
                new Users { Name = "Jane", Password = "password2" },
                new Users { Name = "Alice", Password = "password3" }
            };
                            Users user = users[0];
            int index =users.FindIndex( user);
            Console.WriteLine(index);
        }
    }


}
