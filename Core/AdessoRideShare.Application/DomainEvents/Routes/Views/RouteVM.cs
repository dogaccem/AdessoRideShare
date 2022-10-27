using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdessoRideShare.Application.DomainEvents.Routes.Views
{
    public class RouteVM
    {
        public string? From { get; set; }
        public string? To { get; set; }
        public int SeatingCapacity { get; set; }
        public DateTime StartDate { get; set; }

    }
}
