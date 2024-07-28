using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstruccionProyecto.Model.Entitys
{
    [Table("Route")]
    public class Route
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RouteId { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public double Distance { get; set; }
        public TimeSpan TravelDurationTime { get; set; }
        public double TravelPrice { get; set; }

        public Route() { }

        public Route(int routeId, string origin, string destination, double distance, TimeSpan travelDurationTime, double travelPrice)
        {
            this.RouteId = routeId;
            this.Origin = origin;
            this.Destination = destination;
            this.Distance = distance;
            this.TravelDurationTime = travelDurationTime;
            this.TravelPrice = travelPrice;
        }
    }
}