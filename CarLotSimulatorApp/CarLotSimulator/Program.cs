using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var carLot = new CarLot();
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //Dot Notation
            var charger = new Car();
            charger.Make = "Dodge";
            charger.Model = "Charger";
            charger.Year = 1967;
            charger.EngineNoise = "Perfection";
            charger.HonkNoise = "Honk honk";
            charger.IsDriveable = true;

            carLot.ParkingLot.Add(charger);

            //Object Initializer Syntax
            var honda = new Car() 
            { 
                Make = "Honda",
                Model = "Accord",
                Year = 2021,
                EngineNoise = "Rumble",
                HonkNoise = "Beep",
                IsDriveable = true
            };

            carLot.ParkingLot.Add(honda);

            //Using a custom constructor
            var camry = new Car(2021, "Toyota", "Camry", "Vroom", "Horn", false);

            carLot.ParkingLot.Add(camry);


            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            carLot.CheckCars();
        }
    }
}
