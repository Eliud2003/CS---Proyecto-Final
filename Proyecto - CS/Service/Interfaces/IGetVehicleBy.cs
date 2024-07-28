using ConstruccionProyecto.Model.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto___CS.Service.Interfaces
{
    public interface IGetVehicleBy
    {
        Vehicle GetVehicleByPlate(string plate);
    }
}
