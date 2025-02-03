using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary <int, string> studentList = new Dictionary<int, string>();

        void AddStudent()
        {
            while (true)
            {
                System.Console.Write("Write student ID: ");
                string ID = Console.ReadLine();
                System.Console.Write("Write student name: ");
                string name = Console.ReadLine();
                if (int.TryParse(ID, out int result))
                {
                    if (!studentList.ContainsKey(result))
                    {
                        studentList.Add(result, name);
                        System.Console.WriteLine("Done");
                        break;
                    }
                    else
                        Console.WriteLine("Студент с таким ID уже существует.");
                }
                else
                {
                    Console.WriteLine("Invalid ID, try again");
                }
            }
        }
        void FindStudent()
        {
            while (true)
            {
                System.Console.Write("Write student's ID: ");
                string ID = Console.ReadLine();
                if (int.TryParse(ID, out int result))
                {
                    if (studentList.TryGetValue(Convert.ToInt32(ID), out string name))
                    {
                        System.Console.WriteLine("Student find!");
                        System.Console.WriteLine($"ID: {ID}, Name: {name}");
                    }
                    else
                    {
                        System.Console.WriteLine("Student not found.");
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid ID, try again");
                }
            }

        }
        void ShowAll()
        {
            System.Console.WriteLine("\nAll students: ");
            foreach (KeyValuePair<int, string> entry in studentList)
            {
                System.Console.WriteLine($"ID: {entry.Key}, Name: {entry.Value}");
            }
        }
        while (true)
        {
            System.Console.WriteLine("\nMenu:");
            System.Console.WriteLine("1. Add student");
            System.Console.WriteLine("2. Find student");
            System.Console.WriteLine("3. Show all students");
            System.Console.WriteLine("4. Exit");
            System.Console.Write("Choice: ");
            
            string choice = Console.ReadLine();
            if (int.TryParse(choice, out int result))
            {
                switch(choice)
                {
                    case "1":
                        AddStudent();
                        break;
                    case "2":
                        FindStudent();
                        break;
                    case "3":
                        ShowAll();
                        break;
                    case "4":
                        System.Console.WriteLine("Bye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;

                }
            }
            else
            {
                System.Console.WriteLine("Invalid choice, try again");
            }
        }
        

    }
}