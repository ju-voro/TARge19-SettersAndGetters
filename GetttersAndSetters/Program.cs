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
            string idCode;

            public Person(string _name, string _gender, int _age, string _idCode)
            {
                Name = _name;
                Gender = _gender;
                Age = _age;
                IdCode = _idCode;
            }

            public string IdCode
            {
                get { return idCode; }
                set
                {
                    if(value.Length == 11)
                    {
                        idCode = value;
                    }
                    else
                    {
                        idCode = "undefined";
                    }
                }
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

            public int Age
            {
                get { return age; }
                set
                {
                    if(value >= 0)
                    {
                        age = value;
                    } else
                    {
                        age = 0;
                    }
                }
            }


        }
        static void Main(string[] args)
        {
            Person newPerson = new Person("John", "male", 34, "5010gsghsfbhs1012225");
            Console.WriteLine($"A new person {newPerson.Name}");
            newPerson.Name = "Joanna";
            Console.WriteLine($"Gender: {newPerson.IdCode}");
            Console.WriteLine($"A new person {newPerson.Name}");
            newPerson.Gender = "Fairy";
            Console.WriteLine($"Gender: {newPerson.Gender}");
            Console.WriteLine($"Age: {newPerson.Age}");
        }
    }
}
