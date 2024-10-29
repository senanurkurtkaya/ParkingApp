using Microsoft.EntityFrameworkCore;
using ParkingApp.DataAccess;
using ParkingApp.DataAccess.Entities;
using ParkingApp.UI.Forms;

namespace ParkingApp.UI
{
    public partial class MainWindow : Form
    {
        private int? _selectedCarOwnerId = null;
        private int? _selectedCarId = null;
        public MainWindow()
        {
            InitializeComponent();
        }



        private void tabCarOwners_Enter(object sender, EventArgs e)
        {
            LoadCarOwners();
        }

        private void tsbNewCarOwner_Click(object sender, EventArgs e)
        {
            var addOrUpdateCarOwneForm = new AddOrUpdateCarOwnerForm();
            addOrUpdateCarOwneForm.ShowDialog(this);
        }

        private void tsbRefreshCarOwners_Click(object sender, EventArgs e)
        {
            LoadCarOwners();

        }
        private void LoadCarOwners()
        {
            using (var dbContext = new ParkingDbContext(new Microsoft.EntityFrameworkCore.DbContextOptions<ParkingDbContext>()))
            {
                var carOwners = dbContext.CarOwners
                    .OrderByDescending(x => x.CreatedAt)
                    .ToList();



                dgCarOwners.Columns.Clear();
                dgCarOwners.Columns.Add("Id", "Id");
                dgCarOwners.Columns.Add("IdentityNumber", "IdentityNumber");
                dgCarOwners.Columns.Add("FirstName", "FirstName");
                dgCarOwners.Columns.Add("LastName", "LastName");
                dgCarOwners.Columns.Add("UpdatedAt", "UpdatedAt");
                dgCarOwners.Columns.Add("CreatedAt", "CreatedAt");

                foreach (var carOwner in carOwners)
                {
                    dgCarOwners.Rows.Add(
                        carOwner.Id,
                        carOwner.IdentityNumber,
                        carOwner.FirstName,
                        carOwner.LastName,
                        carOwner.UpdatedAt,
                        carOwner.CreatedAt);
                }

                dgCarOwners.ClearSelection();
                _selectedCarOwnerId = null;
                tsbUpdateCarOwner.Enabled = false;
                tsbDeleteCarOwner.Enabled = false;

            }

        }

        private void dgCarOwners_SelectionChanged(object sender, EventArgs e)
        {
            var dataGrid = ((DataGridView)sender);


            if (dataGrid.SelectedRows.Count > 0)
            {
                _selectedCarOwnerId = (int)dataGrid.SelectedRows[0].Cells[0].Value;
                tsbUpdateCarOwner.Enabled = true;
                tsbDeleteCarOwner.Enabled = true;
            }
        }

        private void tsbUpdateCarOwner_Click(object sender, EventArgs e)
        {
            if (_selectedCarOwnerId.HasValue)
            {
                var addOrUdateCarOwnerForm = new AddOrUpdateCarOwnerForm(_selectedCarOwnerId.Value);
                addOrUdateCarOwnerForm.ShowDialog(this);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tabControl = ((TabControl)sender);

            if (tabControl.SelectedIndex == 0)
            {

                LoadCarOwners();
            }
            else if (tabControl.SelectedIndex == 1)
            {
                LoadCars();
            }
            else
            {
                LoadLicensePlates();
            }
        }

        private void LoadLicensePlates()
        {
            throw new NotImplementedException();
        }

        private void LoadCars()
        {
            using (var dbContext = new ParkingDbContext(new Microsoft.EntityFrameworkCore.DbContextOptions<ParkingDbContext>()))
            {
                var cars = dbContext.Cars
                    .Include(x => x.Owner)
                    .Include(x => x.LicensePlate)

                    .OrderByDescending(x => x.CreatedAt)
                    .ToList();

                dgCars.Columns.Clear();
                dgCars.Columns.Add("Id", "Id");
                dgCars.Columns.Add("IdentityNumber", "IdentityNumber");
                dgCars.Columns.Add("FirstName", "FirstName");
                dgCars.Columns.Add("LastName", "LastName");
                dgCars.Columns.Add("Brand", "Brand");
                dgCars.Columns.Add("Model", "Model");
                dgCars.Columns.Add("Color", "Color");
                dgCars.Columns.Add("LicensePlate", "LicensePlate");
                dgCars.Columns.Add("UpdatedAt", "UpdatedAt");
                dgCars.Columns.Add("CreatedAt", "CreatedAt");

                foreach (var car in cars)
                {
                    dgCars.Rows.Add(
                        car.Id,
                        car.Owner.IdentityNumber,
                        car.Owner.FirstName,
                        car.Owner.LastName,
                        car.Brand,
                        car.Model,
                        car.Color,
                        car.LicensePlate?.FullLicensePlate,
                        car.UpdatedAt,
                        car.CreatedAt);


                }

                dgCars.ClearSelection();
                _selectedCarId = null;
                tsbUpdateCar.Enabled = false;
                tsbDeleteCar.Enabled = false;
                tsbLicensePlate.Enabled = false;
            }
        }

        private void tsbDeleteCarOwner_Click(object sender, EventArgs e)
        {
            if (_selectedCarOwnerId.HasValue)
            {
                var result = MessageBox.Show("Are You Sure To Delete Selected Car Owner", "Delete Car Owner", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (result != DialogResult.Yes)
                {
                    return;

                }
                using (var dbContext = new ParkingDbContext(new Microsoft.EntityFrameworkCore.DbContextOptions<ParkingDbContext>()))
                {
                    var carOwner = dbContext.CarOwners.FirstOrDefault(x => x.Id == _selectedCarOwnerId.Value);

                    if (carOwner != null)
                    {
                        dbContext.Remove(carOwner);
                        dbContext.SaveChanges();

                    }
                }
            }
        }

        private void tsbNewCar_Click(object sender, EventArgs e)
        {
            var addOrUpdateCarForm = new AddOrUpdateCarForm();
            addOrUpdateCarForm.ShowDialog(this);

        }

        private void tsbRefreshCars_Click(object sender, EventArgs e)
        {
            LoadCars();
        }

        private void dgCars_SelectionChanged(object sender, EventArgs e)
        {
            var dataGrid = ((DataGridView)sender);


            if (dataGrid.SelectedRows.Count > 0)
            {
                _selectedCarId = (int)dataGrid.SelectedRows[0].Cells[0].Value;
                tsbUpdateCar.Enabled = true;
                tsbDeleteCar.Enabled = true;
                tsbLicensePlate.Enabled = true;
            }
        }

        private void tsbLicensePlate_Click(object sender, EventArgs e)
        {
            if (_selectedCarId.HasValue)
            {
                var addOrUpdateLicensePlateForm = new AddOrUpdateLicensePlateForm
                    (_selectedCarId.Value);

                addOrUpdateLicensePlateForm.ShowDialog(this);


            }
        }

        private void tsbDeleteCar_Click(object sender, EventArgs e)
        {
            if (_selectedCarId.HasValue)
            {
                var result = MessageBox.Show("Are You Sure To Delete Selected Car ", " Delete Car ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (result != DialogResult.Yes)
                {
                    return;
                }
                using (var dbContext = new ParkingDbContext(new Microsoft.EntityFrameworkCore.DbContextOptions<ParkingDbContext>()))
                {
                    var car = dbContext.Cars.FirstOrDefault(x => x.Id == _selectedCarId.Value);

                    if (car != null)
                    {
                        dbContext.Remove(car);
                        dbContext.SaveChanges();
                    }
                }
            }
        }

        private void tsbUpdateCar_Click(object sender, EventArgs e)
        {
            if (_selectedCarId.HasValue)
            {
                var addOrUpdateCarForm =new AddOrUpdateCarForm(_selectedCarId.Value);
                addOrUpdateCarForm.ShowDialog(this);

            }
        }
    }
}
