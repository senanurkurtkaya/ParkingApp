using Microsoft.EntityFrameworkCore;
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
    public partial class AddOrUpdateCarForm : Form
    {
        private int? _selectedCarId = null;
        public AddOrUpdateCarForm()
        {
            InitializeComponent();
        }

        public AddOrUpdateCarForm(int selectedCarId)
        {
            InitializeComponent();
            _selectedCarId = selectedCarId;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var OwnerIdentityNumber = txtOwnerIdentityNumber.Text;
            var brand = txtBrand.Text;
            var model = txtModel.Text;
            var color = txtColor.Text;

            if (string.IsNullOrEmpty(OwnerIdentityNumber))
            {
                MessageBox.Show("Owner Identity Number is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(brand))
            {
                MessageBox.Show("Brand is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(model))
            {
                MessageBox.Show("Model is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(color))
            {
                MessageBox.Show("Color is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (var dbContext = new ParkingDbContext(new Microsoft.EntityFrameworkCore.DbContextOptions<ParkingDbContext>()))
            {
                var owner = dbContext.CarOwners.FirstOrDefault(x => x.IdentityNumber == OwnerIdentityNumber);

                if (owner == null)
                {
                    MessageBox.Show($"Car Owner With IdentityNumber : {OwnerIdentityNumber} is not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var car = dbContext.Cars
                        .FirstOrDefault(x => x.Id == _selectedCarId.Value);

                if (car == null)
                {
                    car = new Car(owner.Id, brand, model, color);
                    dbContext.Add(car);
                }
                else
                {
                    car.Update(brand, model, color);
                    dbContext.Update(car);
                }

                dbContext.SaveChanges();
                this.Close();
            }
        }

        private void AddOrUpdateCarForm_Load(object sender, EventArgs e)
        {
            if (_selectedCarId.HasValue)
            {
                using (var dbContext = new ParkingDbContext(new Microsoft.EntityFrameworkCore.DbContextOptions<ParkingDbContext>()))
                {

                    var car = dbContext.Cars
                         .Include(x => x.Owner)
                         .FirstOrDefault(x => x.Id == _selectedCarId.Value);

                    if (car != null)
                    {
                        txtBrand.Text = car.Brand;
                        txtModel.Text = car.Model;
                        txtColor.Text = car.Color;
                        txtOwnerIdentityNumber.Text = car.Owner.IdentityNumber;
                        txtOwnerIdentityNumber.ReadOnly = true;
                    }
                }
            }
        }
    }
}
