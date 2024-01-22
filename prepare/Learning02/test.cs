// using System;
// using Microsoft.VisualBasic;


// class Program
// {
//     static void Main(string[] args)
//     {

//         var cars = new List<Car>();

//         var car = new Car();
//             car.make = "Honda"; 
//             car.model = "civic";

//             var owner = new Owner();
//             owner.name = "Jim";
//             car.owner = owner;

//             cars.Add(car);

//             car = new Car();
//             car.make = "Ford"; 
//             car.model = "F-150";

//             cars.Add(car);


//         foreach(var c in cars)
//         {
            
//         }
           
//     }
// }

// public class Car
// {
//     public int gallons;
//     public int milesPerGallon;
//     public string make;
//     // public string model;
//     // public Owner owner;

//     public int TotalRange()
//     {
//         return gallons * milesPerGallon;
//     }

//     public void Display()
//     {
//         System.Console.WriteLine($" {make} {model}");
//     }



// }

// public class Owner
// {

//     public string name;
// }
