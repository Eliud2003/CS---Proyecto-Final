using ConstruccionProyecto.Model.Entitys;
using Proyecto___CS.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto___CS.Controller
{
    public class RouteController
    {
        private IManagement<Route> _routeService;

        public RouteController(IManagement<Route> routeService)
        {
            _routeService = routeService;
        }

        public bool AddRoute(string origin, string destination, double distance, TimeSpan travelDurationTime, double travelPrice)
        {
            var route = new Route
            {
                Origin = origin,
                Destination = destination,
                Distance = distance,
                TravelDurationTime = travelDurationTime,
                TravelPrice = travelPrice
            };
            return _routeService.Create(route);
        }

        public Route GetRouteById(int id)
        {
            return _routeService.Read(id);
        }

        public bool UpdateRoute(string origin, string destination, double distance, TimeSpan travelDurationTime, double travelPrice)
        {
            var route = new Route
            {
                Origin = origin,
                Destination = destination,
                Distance = distance,
                TravelDurationTime = travelDurationTime,
                TravelPrice = travelPrice
            };
            return _routeService.Update(route);
        }

        public bool RemoveRoute(int id)
        {
            return _routeService.Delete(id);
        }

        public List<Route> GetAllRoutes()
        {
            return _routeService.GetList();
        }
    }
}
