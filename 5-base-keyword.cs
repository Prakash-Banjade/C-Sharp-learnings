using System;

namespace BaseKeywordExample {
    class Program {
        class Person {
            protected string Name { get; set; }
            
            public Person(string name) {
                Name = name;
            }

            public void DisplayName() {
                Console.WriteLine(Name);
            }
        }

        class Male: Person {
            public int Age { get; set; }

            public Male(string name, int age): base(name) {
                Age = age;
            }

            public void DisplayInfo() {
                Console.WriteLine(Name + " is " + Age + " years old.");
            }
        }
        
        static void Main() {
            Male maleObj = new Male("Prakash Banjade", 21);
            maleObj.DisplayInfo();
        }
    }
}