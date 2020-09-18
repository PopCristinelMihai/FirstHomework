using System;
using System.Security.Cryptography.X509Certificates;

namespace Curs7Tema2
{
    public abstract class Vehicle
    {
        //Use of an interface, using separate files 
        public int FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }
        public double Distance { get; set; }
        public int RefuelingQuantity { get; set; }
        public bool AC { get; set; }

        public virtual void drive(int x = 1)
        {
            Distance = FuelQuantity/FuelConsumption;
            FuelQuantity = 0;

        }

        /*public virtual void refuelling()
        {
            RefuelingQuantity
        }*/

        public void isACon(bool ac)
        {
            AC = ac;
        }
    }

    class Car : Vehicle
    {
        public Car(int fq, double fc, double dist, int rq, bool ac)
        {
            FuelQuantity = fq;
            FuelConsumption = fc;
            Distance = dist;
            RefuelingQuantity = rq;
            AC = ac;
        }

    }



    class Truck : Vehicle
    {

        public Truck(int fq, double fc, double dist, double rq, bool ac)
        {
            // define just the different attribute in this class , use properties (get;set)
            FuelQuantity = fq;
            FuelConsumption = fc;
            Distance = dist;
            double refueling_quantity = rq;
            AC = ac;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(60, 0.2, 300, 60, false);
            Truck truck = new Truck(210, 0.8, 210, 210, false);
            car.isACon(true);
            if (car.AC == true) {
                car.FuelConsumption += 0.2;
            }
            car.drive();

            Console.WriteLine(car.Distance);
            truck.isACon(true);
            if (truck.AC == true) {
                truck.FuelConsumption += 0.3;
            }
            truck.drive(95);
            Console.WriteLine(truck.Distance);



        }
    }
}
