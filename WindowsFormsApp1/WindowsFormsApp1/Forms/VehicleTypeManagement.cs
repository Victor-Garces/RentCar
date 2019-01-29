using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1.DataLayer;
using WindowsFormsApp1.DataLayer.Models;

namespace WindowsFormsApp1.Forms
{
    public partial class VehicleTypeManagement : Form
    {
        readonly RentCarContext _carContext;

        public VehicleTypeManagement()
        {
            _carContext = new RentCarContext();
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IEnumerable<VehicleType> vehicleTypes = _carContext.VehicleTypes.AsEnumerable();

            foreach (var vehicleType in vehicleTypes)
            {
                vehicleTypeTable.Rows.Add(vehicleType.Description, vehicleType.Status);
            }
        }
    }
}
