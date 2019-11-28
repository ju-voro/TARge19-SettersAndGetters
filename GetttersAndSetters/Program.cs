using System;

namespace GetttersAndSetters
{
    class Program
    {
        class Person
        {
            string name;
            string gender;
            int age;
            public Person(string _name, string _gender, int _age)
            {
                Name = _name;
                gender = _gender;
                age = _age;
            }

            public string Name
            {
                get { return name; }
                set {
                    name = value;
                }
            }

            public string Gender
            {
                get { return gender; }
                set
                {
                    if(value == "male" || value == "female")
                    {
                        gender = value;
                    } else
                    {
                        gender = "unicorn";
                    }
                }
            }


        }
        static void Main(string[] args)
        {
            Person newPerson = new Person("John", "male", 34);
            Console.WriteLine($"A new person {newPerson.Name}");
            newPerson.Name = "Joanna";
            Console.WriteLine($"A new person {newPerson.Name}");
            newPerson.Gender = "Fairy";
            Console.WriteLine($"Gender: {newPerson.Gender}");
        }
    }
}
