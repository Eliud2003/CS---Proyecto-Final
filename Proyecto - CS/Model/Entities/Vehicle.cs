using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConstruccionProyecto.Model.Entitys
{
    [Table("Vehicle")]
    public class Vehicle
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VehicleId { get; set; }
        public string Plate { get; set; }
        public string Model { get; set; }
        public double Mileage { get; set; }
        public double FuelConsumption { get; set; }
        public DateTime ManufacturingDate { get; set; }

        public Vehicle() { }

        public Vehicle(int vehicleId, string plate, string model, double mileage, double fuelConsumption, DateTime manufacturingDate)
        {
            this.VehicleId = vehicleId;
            this.Plate = plate;
            this.Model = model;
            this.Mileage = mileage;
            this.FuelConsumption = fuelConsumption;
            this.ManufacturingDate = manufacturingDate;
        }

    }
}
