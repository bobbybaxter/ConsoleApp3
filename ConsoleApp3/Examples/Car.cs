using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Examples
{
    enum CarColor // enum is essentially options
    {
        Orange = 4003,
        Black,
        Aqua,  // control + .  OR "r, r" to rename
        Maroon,
        Green
    }

    class Car
    {
        public CarColor Color { get; set; }
        public int TopSpeed { get; set; }
        public bool IsInsured { get; set; }

        decimal _gasLevel;
        bool _isRunning;
        Person _driver;
        int _currentSpeed;

        const decimal GasToStart = .5m;  // use TitleCase on constants

        public Car(decimal gasLevel)
        {
            _gasLevel = gasLevel;
        }
        public void Start(Person driver)
        {
            if (_gasLevel > GasToStart)
            {
                _isRunning = true;
                _driver = driver;
                _gasLevel -= .5m;
                Console.WriteLine("Car is started");
            }
            else
            {
                Console.WriteLine("You're out of gas");
            }
        }

        public void Accelerate(int howMuchFaster)
        {
            if (!_isRunning)
            {
                Console.WriteLine("Car is not running, can't accelerate.");
                return;
            }

            _currentSpeed += howMuchFaster;

            _gasLevel -= 10;

            if (_gasLevel <= 0)
            {
                _isRunning = false;
            }
        }

        public decimal Refuel(decimal amountOfGas)
        {
            _gasLevel += amountOfGas;
            return _gasLevel;
        }
    }
}
