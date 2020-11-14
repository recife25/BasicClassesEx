//Felipe Ruiz 
//classes exercise
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicClassesExercise
{
    public class Car
    {
        public Car()
        {

        }
        //multiple contructors - using the concept of method overloading 
        //public Car (string make, string model, int year)//ready to accept three parameters two of string and one of int
        public Car (string makeInput, string modelInput, int yearInput)
        {
            //Make ref property make ref to parameter
            //Make = make;
            // Model = model;
            // Year = year;
            Make = makeInput;
            Model = modelInput;
            Year = yearInput;


        }

        //constructors
        // constructor has a special member method that has the same name as its class
        //fields 
        //properties
        //methods 
        //create a Make property of type string that is public
        public string Make { get; set; } //read = read set = write
        public string Model { get; set; }
        public int Year { get; set; }

    }
}
