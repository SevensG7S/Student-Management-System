# Student-Management-System
This C# program manages a list of students using a Dictionary It allows you to:

1️⃣ Add a student:

    Enter the student’s ID and name.
    The program checks if the ID is unique before adding.

2️⃣ Find a student:

    Look up a student by their ID.
    If found, it displays the student’s details.

3️⃣ Show all students:

    List all students stored in the system.

4️⃣ Exit the program

🔹 How it works:

    The program presents a menu with options to add, find, display all students, or exit.
    It validates input and handles incorrect entries gracefully.
    This is a simple and effective way to understand dictionaries and basic user interaction in C#.
```
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
```
