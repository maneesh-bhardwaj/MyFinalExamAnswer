using System;
using System.Linq;

namespace AnswerToQuestion26
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Adult: Person
    {
        public Adult(string fName, string lName)
        {
            this.FirstName = fName;
            this.LastName = lName;
        }
    }
    class Child: Person
    {
        public Child(string fName, string lName)
        {
            this.FirstName = fName;
            this.LastName = lName;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[10];
            people[0] = new Adult("Maneesh","Bhardwaj");
            people[1] = new Child("Krishiv","Bhardwaj");

            foreach (var item in people.Where(x=> x != null))
            {
                Console.WriteLine($"{item.FirstName}  {item.LastName}");
            }
        }
    }
}
