using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Examples
{
    class Person
    {
        // structure:
        //  properties
        //  fields
        //  constructors
        //  methods

        public string Name { get; } // readonly autoproperty
        public int Age { get; set; }

        int _speed;
        // readonly int _speed;
        // ^ can be a read only FIELD, can't be changed after the thing is constructed
        List<string> _foodInMyBelly = new List<string>();
        int _caloricIntake;
        const int MaxWalkingSpeed = 10;


        public Person(string name, int age, int speed)
        {
            Name = name;
            Age = age;
            _speed = speed;
        }

        // 3 parts to a method signature:
        // access modifier = public or private
        // return type (i.e. void)
        // method name

        private void Walk()
        {
            if (_speed < MaxWalkingSpeed)
            {
                Console.WriteLine($"{Name} is walking at {_speed} feet per second.");
            }
            else
            {
                Console.WriteLine("Slow down you hooligan!!!");
            }
        }

        public void Eat(string foodType, int calories)
        {
            if (_caloricIntake > 2500)
            {
                Console.WriteLine("You may not eat more food.");
                return;
            }
                _foodInMyBelly.Add(foodType);
                _caloricIntake += calories;
        }

        // method overloading
        public void Eat(Food stuffToEat)
        {
            Eat(stuffToEat.Name, stuffToEat.Calories);
        }

        /*
        public void Eat(Food stuffToEat)
        {
            _foodInMyBelly.Add(stuffToEat.Name);
            _caloricIntake += stuffToEat.Calories;
        };
        */
    }
}