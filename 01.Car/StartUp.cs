﻿using System;

namespace CarManufacturer
{
   public class StartUp
   {
     public static void Main()
     {
        Car car = new();
        car.Make = "VW";
        car.Model = "MK3";
        car.Year = 1992;

        Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}");

     }
   }

}

