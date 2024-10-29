using ParkingApp.DataAccess.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApp.DataAccess.Entities
{
    public class LicensePlate :BaseEntity
    {
        public LicensePlate(int carId, string cityCode, string provienceCode)
            : base()
        {
            CarId = carId;
            CityCode = cityCode;
            ProvienceCode = provienceCode;
            RegistrationYear = CreatedAt.ToString("yy");
        }

        public string CityCode { get; private set; }

        public string ProvienceCode { get; private set; }

        public string RegistrationYear { get; private set; }

        public string FullLicensePlate { get; private set; }

        public int CarId { get; private set; }

        public Car Car { get; private set; }

        public void Update(string cityCode, string provienceCode)
        {
            CityCode = cityCode;
            ProvienceCode = provienceCode;
            RegistrationYear = DateTime.Now.ToString("yy");
            UpdatedAt = DateTime.Now;

        }
    }
}
