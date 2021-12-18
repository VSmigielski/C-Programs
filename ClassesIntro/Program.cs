using System;

namespace ClassesIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Car myCar = new Car("Mustang");
            Car anotherCar = new Car("Ford");

            myCar.Accelerate(5);
            myCar.Accelerate(30);
            myCar.Brake();

            anotherCar.Brake();
        }
    }

    class Car
    {
        private int speed = 0;
        private string name;

        public Car(string carName)
        {
            name = carName;
        }

        public void Accelerate(int amount)
        {
            // Adds 1 to current speed
            speed += amount; // speed = speed + amount
            ShowSpeed();
        }

        public void Brake()
        {
            // Subtracts 1 to current speed
            speed--;
            ShowSpeed();
        }

        private void ShowSpeed()
        {
            Console.WriteLine($"{name} is going {speed} kilometers per hour.");
        }
    }
}
