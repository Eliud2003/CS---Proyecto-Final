using ConstruccionProyecto.Model.Entitys;
using Proyecto___CS.Repository;
using Proyecto___CS.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto___CS.Service.Services
{
    public class VehicleService : IGetVehicleBy
    {
        private readonly AppDbContext _context;

        public VehicleService(AppDbContext context)
        {
            _context = context;
        }

        public Vehicle GetVehicleByPlate(string plate)
        {
            return _context.Vehicles.SingleOrDefault(v => v.Plate == plate);
        }
    }
}
