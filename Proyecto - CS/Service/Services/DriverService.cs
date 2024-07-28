using ConstruccionProyecto.Model.Entitys;
using Proyecto___CS.Repository;
using Proyecto___CS.Service.Interfaces;

namespace Proyecto___CS.Service.Services
{
    public class DriverService : IGetDriverBy
    {
        private readonly AppDbContext _context;

        public DriverService(AppDbContext context)
        {
            _context = context;
        }

        public Driver GetDriverByDni(string dni)
        {
            return _context.Drivers.SingleOrDefault(d => d.Dni == dni);
        }

        public List<Driver> GetDriverByName(string name)
        {
            return _context.Drivers.Where(d => d.FirstName.Contains(name) || d.LastName.Contains(name)).ToList();
        }
    }
}

