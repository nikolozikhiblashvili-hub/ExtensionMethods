namespace Lesson5_Homework
{
    internal class Program
    {
        static List<string> students = new List<string>();
        static Dictionary<string, int> grades = new Dictionary<string, int>();

        static void AddStudent()
        {
            Console.Write("შეიყვანეთ სტუდენტის სახელი: ");
            string name = Console.ReadLine()!;

            if (grades.ContainsKey(name))
            {
                Console.WriteLine("სტუდენტი უკვე არსებობს!");
                return;
            }

            Console.Write("შეიყვანეთ ქულა: ");
            int grade = int.Parse(Console.ReadLine()!);

            students.Add(name);
            grades.Add(name, grade);

            Console.WriteLine("სტუდენტი წარმატებით დაემატა!");
        }

        static void SearchStudent()
        {
            Console.Write("შეიყვანეთ სტუდენტის სახელი: ");
            string name = Console.ReadLine()!;

            if (grades.ContainsKey(name))
            {
                Console.WriteLine($"სტუდენტი: {name}, ქულა: {grades[name]}");
            }
            else
            {
                Console.WriteLine("სტუდენტი ვერ მოიძებნა");
            }
        }

        static void UpdateGrade()
        {
            Console.Write("შეიყვანეთ სტუდენტის სახელი: ");
            string name = Console.ReadLine()!;

            if (grades.ContainsKey(name))
            {
                Console.Write("შეიყვანეთ ახალი ქულა: ");
                int newGrade = int.Parse(Console.ReadLine()!);

                grades[name] = newGrade;

                Console.WriteLine("ქულა წარმატებით განახლდა!");
            }
            else
            {
                Console.WriteLine("სტუდენტი ვერ მოიძებნა");
            }
        }

        static void ShowAllStudents()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("სტუდენტები არ არის დამატებული.");
                return;
            }

            foreach (string name in students)
            {
                Console.WriteLine($"სტუდენტი: {name}, ქულა: {grades[name]}");
            }
        }

        static void Main()
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            while (true)
            {
                Console.WriteLine("\n--- სტუდენტების მართვის სისტემა ---");
                Console.WriteLine("1. სტუდენტის დამატება");
                Console.WriteLine("2. სტუდენტის ძებნა");
                Console.WriteLine("3. ქულის განახლება");
                Console.WriteLine("4. ყველა სტუდენტის ჩვენება");
                Console.WriteLine("0. გამოსვლა");
                Console.Write("აირჩიეთ მოქმედება: ");

                string choice = Console.ReadLine()!;

                switch (choice)
                {
                    case "1":
                        AddStudent();
                        break;

                    case "2":
                        SearchStudent();
                        break;

                    case "3":
                        UpdateGrade();
                        break;

                    case "4":
                        ShowAllStudents();
                        break;

                    case "0":
                        return;

                    default:
                        Console.WriteLine("არასწორი არჩევანი!");
                        break;
                }
            }
        }
    }
}
