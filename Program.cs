//Felipe Ruiz - aka Phil 
//classes 
using System;
using System.Collections.Generic;


namespace BasicClassesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //here is my Main Method 
            // var myCar = new Car(); //new Car(); here is a constructor special member method which helps us create a new instance of the Car class 
            //dot notation 
            Car myCar = new Car();
            myCar.Make = "Ford";
            myCar.Model = "Focus";
            myCar.Year = 2013;

            var Toyota = new Car()//another way to store value in an object property
            //object initializer 
            {
                Make = "Toyota",
                Model = "Avalon",
                Year = 1995
            };
            //passing it through the constructor
            //with two overloads with or without parameters 
            var chevy = new Car("Chevy", "Impala", 2001);

            var carList = new List<Car>() { myCar, Toyota, chevy, new Car(), new Car()};
            //Console.WriteLine(carList.Capacity);
            foreach (var vehicle in carList)
            {
                Console.WriteLine($"{vehicle.Make} {vehicle.Model} {vehicle.Year}");
            }


        }
    }
}
