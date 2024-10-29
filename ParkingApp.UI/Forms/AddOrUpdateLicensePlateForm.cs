using ParkingApp.DataAccess;
using ParkingApp.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingApp.UI.Forms
{
    public partial class AddOrUpdateLicensePlateForm : Form
    {
        private readonly int _carId;

        public AddOrUpdateLicensePlateForm(int carId)
        {
            InitializeComponent();
            _carId = carId;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var cityCode = txtCityCode.Text;
            var provienceCode = txtProvienceCode.Text;

            if (string.IsNullOrEmpty(cityCode))
            {
                MessageBox.Show("City Code is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(provienceCode))
            {
                MessageBox.Show("Provience  Code is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (var dbContext = new ParkingDbContext(new Microsoft.EntityFrameworkCore.DbContextOptions<ParkingDbContext>()))
            {
                var licensePlate = dbContext.LicensePlates.FirstOrDefault(x => x.CarId == _carId);
                if(licensePlate == null)
                {
                    licensePlate = new LicensePlate(_carId, cityCode, provienceCode);
                    dbContext.Add(licensePlate);
                }
                else
                {
                    licensePlate.Update(cityCode, provienceCode);
                    dbContext.Update(licensePlate);
                }
    
                dbContext.SaveChanges();

                this.Close();
            }
        }

        private void AddOrUpdateLicensePlateForm_Load(object sender, EventArgs e)
        {
            using (var dbContext = new ParkingDbContext(new Microsoft.EntityFrameworkCore.DbContextOptions<ParkingDbContext>()))
            {
               var licensePlate = dbContext.LicensePlates.FirstOrDefault(x => x.CarId == _carId);
                
                if(licensePlate != null)
                {
                    txtCityCode.Text = licensePlate.CityCode;
                    txtProvienceCode.Text = licensePlate.ProvienceCode;

                }
            }
        }
    }
}
