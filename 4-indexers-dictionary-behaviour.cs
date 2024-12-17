using System;
using System.Collections.Generic;

class StudentGrades
{
    private Dictionary<string, int> grades = new Dictionary<string, int>();

    // Indexer with string key
    public int this[string studentName]
    {
        get
        {
            if (grades.ContainsKey(studentName))
                return grades[studentName];
            else
                throw new KeyNotFoundException("Student not found");
        }
        set
        {
            grades[studentName] = value;
        }
    }
}

class Program
{
    static void Main()
    {
        StudentGrades studentGrades = new StudentGrades();

        // Setting values using the indexer
        studentGrades["Alice"] = 85;
        studentGrades["Bob"] = 92;

        // Getting values using the indexer
        Console.WriteLine("Alice's grade: " + studentGrades["Alice"]);
        Console.WriteLine("Bob's grade: " + studentGrades["Bob"]);   
    }
}
