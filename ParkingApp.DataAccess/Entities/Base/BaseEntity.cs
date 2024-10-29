using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApp.DataAccess.Entities.Base
{
    public abstract class BaseEntity
    {
        protected BaseEntity()
        {
            CreatedAt = DateTime.Now;
        }
        public int Id { get; private set; }

        public DateTime? UpdatedAt { get; protected set; }

        public  DateTime CreatedAt { get; private set; }
    }
}
