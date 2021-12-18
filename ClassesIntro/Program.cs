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
            myCar.Brake(10);

            anotherCar.Accelerate(2);
            anotherCar.Brake(5);
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

        public void Brake(int speedReduction)
        {
            // Subtracts 1 to current speed
            speed -= speedReduction;

            if (speed < 0)
            {
                speed = 0;
            }

            // Another way to ensure speed is not negative
            /*if (speed < speedReduction)
            {
                speed = 0;
            } else
            {
                speed -= speedReduction;
            }*/

            // Ternary way
            /* speed = (speed < speedReduction) 
             * ? 0 : speed - speedReduction;*/

            ShowSpeed();
        }

        private void ShowSpeed()
        {
            Console.WriteLine($"{name} is going {speed} kilometers per hour.");
        }
    }
}
