using System;

namespace krlab4_interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Plane plane = new Plane(200,"Boing 747");
            plane.Time();
            plane.Cost();
            Train train = new Train(576, "Parovozik");
            train.Time();
            train.Cost();
            Car car = new Car(140, "Gelik");
            car.Time();
            car.Cost();
            Helicopter helicopter = new Helicopter(345, "Apache");
            helicopter.Time();
            helicopter.Cost();
            FlyingMachine flyingMachine = new FlyingMachine(34,"Karlson");
            flyingMachine.Time();
            flyingMachine.Cost();
        }
    }

    abstract class Transport
    {
        public double Distance { get; set; }
        public string Name { get; set; }
        public Transport(double distance, string name)
        {
            Distance = distance;
            Name = name;
        }
        public abstract void Cost();
    }

    class Plane : Transport
    {
        private double Velocity = 900;
        public Plane(double distance, string name): base(distance, name)
        {
            Distance = distance;
            Name = name;
        }
        public override void Cost()
        {
            double cost = Distance * 100;
            Console.WriteLine($"It will cost {cost} for {Name}");
        }
        public void Time()
        {
            double time = Distance / Velocity;
            Console.WriteLine("It will take " + time + $" hours to travel by {Name}");
        }
    }
    class Train : Transport
    {
        private double Velocity = 55;
        public Train(double distance, string name) : base(distance, name)
        {
            Distance = distance;
            Name = name;
        }
        public override void Cost()
        {
            double cost = Distance * 40;
            Console.WriteLine($"It will cost {cost} for {Name}");
        }
        public void Time()
        {
            double time = Distance / Velocity;
            Console.WriteLine("It will take " + time + $" hours to travel by {Name}");
        }
    }
    class Helicopter : Transport
    {
        private double Velocity = 900;
        public Helicopter(double distance, string name) : base(distance, name)
        {
            Distance = distance;
            Name = name;
        }
        public override void Cost()
        {
            double cost = Distance * 35;
            Console.WriteLine($"It will cost {cost} for {Name}");
        }
        public void Time()
        {
            double time = Distance / Velocity;
            Console.WriteLine("It will take " + time + $" hours to travel by {Name}");
        }
    }
    class Car : Transport
    {
        private double Velocity = 900;
        public Car(double distance, string name) : base(distance, name)
        {
            Distance = distance;
            Name = name;
        }
        public override void Cost()
        {
            double cost = Distance * 27.6;
            Console.WriteLine($"It will cost {cost} for {Name}");
        }
        public void Time()
        {
            double time = Distance / Velocity;
            Console.WriteLine("It will take " + time + $" hours to travel by {Name}");
        }
    }
    class FlyingMachine : Transport
    {
        private double Velocity = 900;
        public FlyingMachine(double distance, string name) : base(distance, name)
        {
            Distance = distance;
            Name = name;
        }
        public override void Cost()
        {
            double cost = Distance * 35;
            Console.WriteLine($"It will cost {cost} for {Name}");
        }
        public void Time()
        {
            double time = Distance / Velocity;
            Console.WriteLine("It will take " + time + $" hours to travel by {Name}");
        }
    }
}
