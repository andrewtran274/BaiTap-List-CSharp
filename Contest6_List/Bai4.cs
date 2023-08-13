using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Tạo một danh sách các đối tượng và thực hiện sắp xếp
//chúng theo một thuộc tính cụ thể,
//nhưng cho phép đối tượng null ở cuối danh sách.

namespace Contest6_List
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age) { 
            Name = name;
            Age = age;
        }
    }

    internal class Bai4
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>()
            {
                new Person("Tuan Hung", 20),
                new Person("Tuan Thinh", 19),
                new Person("Ngoc Yen", 18),
                new Person("Thi Thuy", 21),
                new Person("Nam Van", 17),
                null,
                new Person("Tuan Tu", 20),
                new Person("Xuan Thanh", 17),
                null,
            };
            list.Sort(ComparreAgeASC);
            Console.WriteLine("Danh Sap Sap Xep Theo Tuoi Tang Dan: ");
            foreach (Person person in list)
            {
                if(person != null)
                {
                    Console.WriteLine($"{person.Name}: {person.Age}");
                }
                else
                {
                    Console.WriteLine($"Null");
                }
            }
            Console.WriteLine();
        }

        static int ComparreAgeASC(Person x, Person y)
        {
            if (x == null && y != null)
            {
                return 1;
            }
            else if(x != null && y == null)
            {
                return -1;
            }else if(x != null && y != null)
            {
                if(x.Age > y.Age)
                {
                    return 1;
                }
                else if(x.Age < y.Age){
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }
    }
}
