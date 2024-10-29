using ParkingApp.DataAccess.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApp.DataAccess.Entities
{
    public class Car :BaseEntity
    {
        public Car(int ownerId, string brand, string model, string color)
            :base()
        {
            OwnerId = ownerId;
            Brand = brand;
            Model = model;
            Color = color;
        }

        public string Brand { get; private set; }

        public string Model { get; private set; }

        public string Color { get; private set; }

        public int OwnerId { get; private set; }

        public CarOwner Owner { get; private set; }
        public int? LicensePlateId { get; private set; }
        public LicensePlate  LicensePlate { get; private set; }

        public void Update (String brand , string model, string color)
        {
            Brand = brand;
            Model = model;  
            Color = color;
            UpdatedAt = DateTime.Now;    
        }

    }
}
