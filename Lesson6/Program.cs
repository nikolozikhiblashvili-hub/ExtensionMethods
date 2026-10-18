using System.Security.Cryptography.X509Certificates;

namespace Lesson6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<string> names = new() { "John", "Jane", "Alice", "Bob" };

            //Dictionary<string, int> nameScores = new()
            //{
            //    {"John", 85 },
            //    {"Jane", 92 },
            //    {"Alice", 78 },
            //    {"Bob", 96 }
            //};

            //string name = Console.ReadLine();

            //if (nameScores.ContainsKey(name))
            //{
            //    Console.WriteLine($"Score of {name}: {nameScores[name]}");
            //    Console.WriteLine("add new with x");
            //    string exit = Console.ReadLine();
            //    if (exit == "x")
            //    {
            //        Console.WriteLine("Enter new name:");
            //        string newName = Console.ReadLine();
            //        Console.WriteLine("Enter new score:");
            //        int newScore = int.Parse(Console.ReadLine());
            //        nameScores[newName] = newScore;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine($"Name {name} not found ");
            //}


            //Console.WriteLine("Enter 1 to add student");
            //Console.WriteLine("Enter 2 to find student");
            //Console.WriteLine("Enter 3 to change score");
            //Console.WriteLine("Enter 4 to show all");

            //string choice = Console.ReadLine();
            //switch (choice)
            //{
            //    case "1":
            //        Console.WriteLine("Enter new name:");
            //        string newName = Console.ReadLine();
            //        Console.WriteLine("Enter new score:");
            //        int newScore = int.Parse(Console.ReadLine());
            //        nameScores[newName] = newScore;
            //        break;
            //    case "2":
            //        Console.WriteLine("Enter name to find:");
            //        string findName = Console.ReadLine();
            //        if (nameScores.ContainsKey(findName))
            //        {
            //            Console.WriteLine($"Score of {findName}: {nameScores[findName]}");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"Name {findName} not found ");
            //        }
            //        break;
            //    case "3":
            //        Console.WriteLine("Enter name to change score:");
            //        string changeName = Console.ReadLine();
            //        if (nameScores.ContainsKey(changeName))
            //        {
            //            Console.WriteLine("Enter new score:");
            //            int changeScore = int.Parse(Console.ReadLine());
            //            nameScores[changeName] = changeScore;
            //            Console.WriteLine($"Score of {changeName} changed to {changeScore}");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"Name {changeName} not found ");
            //        }
            //        break;
            //    case "4":
            //        foreach (var kvp in nameScores)
            //        {
            //            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            //        }
            //        break;
            //    default:
            //        Console.WriteLine("Invalid choice");
            //        break;
            //}



        }
    }
}
