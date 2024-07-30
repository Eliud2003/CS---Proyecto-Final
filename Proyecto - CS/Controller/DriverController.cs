using ConstruccionProyecto.Model.Entitys;
using Proyecto___CS.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto___CS.Controller
{
    public class DriverController
    {
        private IManagement<Driver> _managementService;
        private readonly IGetDriverBy _driverService;

        public DriverController(IManagement<Driver> managementService, IGetDriverBy driverService)
        {
            _managementService = managementService;
            _driverService = driverService;
        }

        public bool AddDriver(string firstName, string lastName, string dni, string phoneNumber, string address, string typeOfLicense, DateTime birthDate, int vehicleId)
        {
            var driver = new Driver
            {
                FirstName = firstName,
                LastName = lastName,
                Dni = dni,
                PhoneNumber = phoneNumber,
                Address = address,
                TypeOfLicense = typeOfLicense,
                BirthDate = birthDate,
                VehicleId = vehicleId
            };
            return _managementService.Create(driver);
        }

        public Driver GetDriverById(int id)
        {
            return _managementService.Read(id);
        }

        public Driver GetDriverByDni(string dni)
        {
            return _driverService.GetDriverByDni(dni);
        }

        public List<Driver> GetDriverByName(string name)
        {
            return _driverService.GetDriverByName(name);
        }

        public bool UpdateDriver(int id,string firstName, string lastName, string dni, string phoneNumber, string address, string typeOfLicense, DateTime birthDate, int vehicleId)
        {
            var driver = new Driver
            {
                DriverId = id,
                FirstName = firstName,
                LastName = lastName,
                Dni = dni,
                PhoneNumber = phoneNumber,
                Address = address,
                TypeOfLicense = typeOfLicense,
                BirthDate = birthDate,
                VehicleId = vehicleId
            };
            return _managementService.Update(id,driver);
        }

        public bool RemoveDriver(int id)
        {
            return _managementService.Delete(id);
        }

        public List<Driver> GetAllDrivers()
        {
            return _managementService.GetList();
        }
    }
}
