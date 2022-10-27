using AdessoRideShare.Common.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdessoRideShare.Domain.Entities
{
    public class Route : EntityBase, IEntity
    {
        public string? From { get; set; }
        public string? To { get; set; }
        public int SeatingCapacity { get; set; }
        public DateTime StartDate { get; set; }
        public int UserId { get; set; }
        public ApplicationUser User { get; set; }
        public bool IsActive { get; set; }
        public ICollection<Participant>? Participants { get; set; } = new List<Participant>();

        public Route(string from, string to, int seatingCapacity, int userId, bool isActive = true)
        {
            From = from;
            To = to;
            SeatingCapacity = seatingCapacity;
            UserId = userId;
            IsActive = isActive;
        }
    }
}
