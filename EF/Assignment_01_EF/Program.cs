//============================================================================================\\
//===================================Assignment_03(EF)========================================\\
//============================================================================================\\

namespace Assignment_01_EF;
using Microsoft.EntityFrameworkCore;

class Program
{
    static void Main(string[] args)
    {
        #region Vehicles
            
        // using (SchoolContext context = new SchoolContext())
        // {
        //     try
        //     {
        //         Car car01 = new Car()
        //         {
        //             Name = "tesla",
        //             Model = "model0x1",
        //             NumberOfDoors = 2
        //         };
        //         Car car02 = new Car()
        //         {
        //             Name = "Tesla",
        //             Model = "model0x2",
        //             NumberOfDoors = 4
        //         };
        //         Truck truck01 = new Truck()
        //         {
        //             Name = "ford",
        //             Model = "fx",
        //             LoadCapacity = 500
        //         };
        //         Truck truck02 = new Truck()
        //         {
        //             Name = "ford",
        //             Model = "fx2",
        //             LoadCapacity = 700
        //         };
        //         context.Cars.Add(car01);
        //         context.Cars.Add(car02);
        //         context.Trucks.Add(truck01);
        //         context.Trucks.Add(truck02);
        //         context.SaveChanges();
        //
        //         var cars = context.Vehicles.Where(x => EF.Property<string>(x, "VehicleType") == "Car").ToList();
        //         // foreach (var car in context.Vehicles.OfType<Car>())
        //         //{
        //         //    Console.WriteLine(car);
        //         //}
        //         foreach (var car in context.Cars)
        //         {
        //             Console.WriteLine(car);
        //         }
        //
        //
        //     }
        //     catch (Exception ex)
        //     {
        //         Console.WriteLine(ex.Message);
        //         Console.WriteLine(ex.InnerException);
        //     }
        // }

        #endregion
    }
}