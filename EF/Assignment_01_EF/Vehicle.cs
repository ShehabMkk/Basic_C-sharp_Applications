using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Assignment_01_EF
{
    public abstract class Vehicle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
    }

    public class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }

        public override string ToString()
            => $"Car => Id=>{Id}, Name=>{Name}, Model=>{Model},NumberOfDoors=>{NumberOfDoors}";
    }

    public class Truck : Vehicle
    {
        public int LoadCapacity { get; set; }
        
        public override string ToString()
            => $"Truck => Id => {Id}, Name => {Name}, Model => {Model},LoadCapacity => {LoadCapacity}";
    }

}
