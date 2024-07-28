using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstruccionProyecto.Model.Entitys
{
    [Table("Driver")]
    public class Driver
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DriverId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Dni { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string TypeOfLicense { get; set; }
        public DateTime BirthDate { get; set; }
        public int VehicleId { get; set; }
        [ForeignKey("VehicleId")]
        public Vehicle Vehicle { get; set; }

        public Driver() { }

        public Driver(int driverId, string firstName, string lastName, string dni, string phoneNumber, string address, string typeOfLicense, DateTime birthDate, Vehicle vehicle)
        {
            DriverId = driverId;
            FirstName = firstName;
            LastName = lastName;
            Dni = dni;
            PhoneNumber = phoneNumber;
            Address = address;
            TypeOfLicense = typeOfLicense;
            BirthDate = birthDate;
            Vehicle = vehicle;
        }
    }
}
