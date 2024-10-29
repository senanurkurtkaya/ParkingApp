using ParkingApp.DataAccess.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApp.DataAccess.Entities
{
    public class CarOwner : BaseEntity
    {
        private readonly List<Car> _cars = new List<Car>();

        public CarOwner(string identityNumber, string firstName, string lastName)
            : base()
        {
            IdentityNumber = identityNumber;
            FirstName = firstName;
            LastName = lastName;
        }

        public string IdentityNumber { get; private set; }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public IReadOnlyList<Car> Cars  => _cars;

        public void Update(string identityNumber, string firstName, string lastName)
        {
            IdentityNumber = identityNumber;
            FirstName = firstName;
            LastName = lastName;

            UpdatedAt = DateTime.Now;
        }
    }
}
