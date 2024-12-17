using System;

namespace ExampleString {
    class Program {
        static void Main() {
            // declaration + definition
            string fullName = "Prakash Banjade";
            string fullName2 = "prakash banjade";

            // declaration
            string caste;
            // definition
            caste = "No caste";

            // null string;
            string null_string = null;

            Console.WriteLine(fullName);
            Console.WriteLine(caste);
            Console.WriteLine(null_string); // nothing is displayed

            // common properties and methods -->
            Console.WriteLine("Length of fullName: "  + fullName.Length);
            Console.WriteLine("First letter of firstName: " + fullName[0]);
            // Equality check
            bool isFullNameEqual = fullName == fullName2; // false (case-sensitive)
            Console.WriteLine(isFullNameEqual);
            bool isFullNameEqualIgnoreCase = string.Equals(fullName, fullName2, StringComparison.OrdinalIgnoreCase);
            Console.WriteLine(isFullNameEqualIgnoreCase);

            Console.WriteLine(fullName.Substring(0, 7));
            Console.WriteLine(fullName.IndexOf("P"));
            Console.WriteLine(fullName.Contains("Prakash"));
            Console.WriteLine("      Prakash   ".Trim());
            Console.WriteLine(fullName.Split(','));

            // null or empty check
            string input = " ";
            bool isNullOrEmpty = string.IsNullOrEmpty(input);
            bool isNullOrWhiteSpace = string.IsNullOrWhiteSpace(input);
            Console.WriteLine("isNullOrEmpty: " + isNullOrEmpty);
            Console.WriteLine("isNullOrWhiteSpace: " + isNullOrWhiteSpace);
        }
    }
}