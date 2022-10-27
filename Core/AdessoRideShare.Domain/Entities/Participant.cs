using AdessoRideShare.Common.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdessoRideShare.Domain.Entities
{
    public class Participant : EntityBase, IEntity
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int RouteId { get; set; }
        public Route Route { get; set; }

        public Participant(string firstName, string lastName,int routeId)
        {
            FirstName = firstName; 
            LastName = lastName;
            RouteId = routeId;
        }
    }
}
