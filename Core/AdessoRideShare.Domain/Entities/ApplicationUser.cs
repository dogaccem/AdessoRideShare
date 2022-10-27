using AdessoRideShare.Common.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdessoRideShare.Domain.Entities
{
    public class ApplicationUser : EntityBase, IEntity
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public ICollection<Route>? Routes { get; set; } = new List<Route>();

        public ApplicationUser(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
