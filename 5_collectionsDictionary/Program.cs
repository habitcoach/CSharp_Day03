using System;
using System.Collections.Generic;

namespace collectionDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a Dictionary to store student names and their corresponding ages
            Dictionary<string, int> studentAges = new Dictionary<string, int>();

            // Add some students and their ages to the dictionary
            studentAges.Add("John", 20);
            studentAges.Add("Jane", 22);
            studentAges.Add("Bob", 19);
            studentAges.Add("Alice", 21);

            // Display all students and their ages in the dictionary
            Console.WriteLine("Student names and ages:");
            foreach (var student in studentAges)
            {
                Console.WriteLine($"{student.Key}: {student.Value} years old");
            }

            // Access and print the age of a specific student
            string studentName = "Bob";
            if (studentAges.ContainsKey(studentName))
            {
                int age = studentAges[studentName];

                Console.WriteLine($"\n{studentName}'s age is {age}.");
            }
            else
            {
                Console.WriteLine($"\nStudent {studentName} not found in the dictionary.");
            }

            // Update the age of a student
            string studentToUpdate = "John";
            if (studentAges.ContainsKey(studentToUpdate))
            {
                studentAges[studentToUpdate] = 21;
                Console.WriteLine($"\nUpdated {studentToUpdate}'s age to 21.");
            }
            else
            {
                Console.WriteLine($"\nStudent {studentToUpdate} not found in the dictionary.");
            }

            // Display all students and their ages after the update

            Console.WriteLine("\nAll students and their ages after the update:");
            foreach (var student in studentAges)
            {
                Console.WriteLine($"{student.Key}: {student.Value} years old");
            }

            // Remove a student from the dictionary
            string studentToRemove = "Jane";
            if (studentAges.Remove(studentToRemove))
            {
                Console.WriteLine($"\nRemoved {studentToRemove} from the dictionary.");
            }
            else
            {
                Console.WriteLine($"\nStudent {studentToRemove} not found in the dictionary.");
            }

            // Display all students and their ages after the removal
            Console.WriteLine("\nAll students and their ages after the removal:");
            foreach (var student in studentAges)
            {
                Console.WriteLine($"{student.Key}: {student.Value} years old");
            }

            Console.ReadLine();
        }
    }
}
