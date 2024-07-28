using ConstruccionProyecto.Model.Entitys;
using Proyecto___CS.Service.Interfaces;
using Proyecto___CS.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto___CS.Controller
{
    public class VehicleController
    {
        private IManagement<Vehicle> _managementService;
        private readonly IGetVehicleBy _vehicleService;

        public VehicleController(IManagement<Vehicle> managementService, IGetVehicleBy vehicleService)
        {
            _managementService = managementService;
            _vehicleService = vehicleService;
        }

        public bool AddVehicle(string plate, string model, double mileage, double fuelConsumption, DateTime manufacturingDate)
        {
            var vehicle = new Vehicle
            {
                Plate = plate,
                Model = model,
                Mileage = mileage,
                FuelConsumption = fuelConsumption,
                ManufacturingDate = manufacturingDate
            };

            return _managementService.Create(vehicle);
        }

        public Vehicle GetVehicleById(int id)
        {
            return _managementService.Read(id);
        }

        public Vehicle GetVehicleByPlate(string plate)
        {
            return _vehicleService.GetVehicleByPlate(plate);
        }

        public bool UpdateDriver(string plate, string model, double mileage, double fuelConsumption, DateTime manufacturingDate)
        {
            var vehicle = new Vehicle
            {
                Plate = plate,
                Model = model,
                Mileage = mileage,
                FuelConsumption = fuelConsumption,
                ManufacturingDate = manufacturingDate
            };
            return _managementService.Update(vehicle);
        }

        public bool RemoveVehicle(int id)
        {
            return _managementService.Delete(id);
        }

        public List<Vehicle> GetAllVehicles()
        {
            return _managementService.GetList();
        }
    }
}
