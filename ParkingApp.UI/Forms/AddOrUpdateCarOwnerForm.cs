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
    
    public partial class AddOrUpdateCarOwnerForm : Form
    {
        private readonly int?  _selectedCarOwnerId = null;

        public AddOrUpdateCarOwnerForm()
        {
            InitializeComponent();
            
        }
        public AddOrUpdateCarOwnerForm(int selectedCarOwnerId)
        {
            InitializeComponent();
            _selectedCarOwnerId = selectedCarOwnerId;

            using (var dbContext = new ParkingDbContext(new Microsoft.EntityFrameworkCore.DbContextOptions<ParkingDbContext>()))
            {
                var carOwner=dbContext.CarOwners.FirstOrDefault(x => x.Id == _selectedCarOwnerId.Value);

                if (carOwner != null)
                {
                    txtIdentityNumber.Text = carOwner.IdentityNumber;
                    txtFirstName.Text = carOwner.FirstName;
                    txtLastName.Text = carOwner.LastName;
                }
            }
        }   

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var IdentityNumber = txtIdentityNumber.Text;
            var FirstName =txtFirstName.Text;
            var LastName =txtLastName.Text;

            if(string.IsNullOrEmpty(IdentityNumber))
            {
                MessageBox.Show("IdentityNumber is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(FirstName))
            {
                MessageBox.Show("Firdt Name is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(LastName))
            {
                MessageBox.Show("Last Name is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } 

            using (var dbContext = new ParkingDbContext(new Microsoft.EntityFrameworkCore.DbContextOptions<ParkingDbContext>()))
            {
                if(_selectedCarOwnerId.HasValue)
                {
                    var carOwner = dbContext.CarOwners.FirstOrDefault(x => x.Id == _selectedCarOwnerId.Value);

                    carOwner.Update(IdentityNumber,FirstName, LastName);
                    dbContext.Update(carOwner);
                }
                else
                {
                    var carOwner = new CarOwner(IdentityNumber, FirstName, LastName);
                    dbContext.Add(carOwner);
                    
                }

                dbContext.SaveChanges();
                this.Close();
            }
        }
    }
}
