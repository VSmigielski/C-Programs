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

            myCar.Accelerate();
            myCar.Accelerate();
            myCar.Accelerate();
            myCar.Accelerate();
            myCar.Brake();
            myCar.Accelerate();

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

        public void Accelerate()
        {
            // Adds 1 to current speed
            speed++;
            showSpeed();
        }

        public void Brake()
        {
            // Subtracts 1 to current speed
            speed--;
            showSpeed();
        }

        private void showSpeed()
        {
            Console.WriteLine($"{name} is going {speed} kilometers per hour.");
        }
    }
}
