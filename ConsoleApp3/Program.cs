
using System;
using System.Collections.Generic;
using ConsoleApp3.Examples;

namespace ConsoleApp3
{
    class Program
    {
        string FullName { get; set; } //property

        static void Main(string[] args)
        {
            Console.WriteLine("enter full name");
            //Console = class, .WriteLine() is method on the class
            var input = Console.ReadLine();

            var name = new Name
            {
                FullName = input,
                FirstName = "steve"
            };

            var anotherName = new Name
            {
                FullName = "bob",
                FirstName = "bobby"
            };

            var differentKindsOfThings = new List<object>();

            differentKindsOfThings.Add(anotherName);

            differentKindsOfThings.Add(123);

            var originalPerson = new Person(input, 17, 200);

            var anotherOriginalPerson = new Person(input, 17, 200);

            var pointer = originalPerson;

            if (originalPerson == anotherOriginalPerson)
            {
                Console.WriteLine("This will never happen.");
            }

            if (originalPerson == pointer)
            {
                Console.WriteLine("This will never happen.");
            }

            var steve = new Person(input
                , 17, 200);

            // var name = new Name {FullName = input};

            Console.WriteLine(input);

            originalPerson.Eat(new Food { Name = "Pizza", Calories = 1100 });

            var myCar = new Car(5);

            myCar.Color = CarColor.Aqua;

            myCar.Start(originalPerson);
            myCar.Accelerate(40);
            myCar.Accelerate(40);
            myCar.Accelerate(40);

            // looping over lists of a constructed class
            var people = new List<Person>();
            people.Add(originalPerson);
            people.Add(anotherOriginalPerson);

            foreach (var person in people)
            {
                person.Eat("taco", 300);
            }

            Console.ReadLine();
        }
    }
}