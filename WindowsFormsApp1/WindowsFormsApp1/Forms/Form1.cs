using System;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1.DataLayer;

namespace WindowsFormsApp1.Forms
{
    public partial class Form1 : Form
    {
        readonly RentCarContext _carContext;

        public Form1()
        {
            _carContext = new RentCarContext();
            InitializeComponent();
        }

        private void Enter(object sender, EventArgs e)
        {
            string userName = txtUsername.Text;
            string password = txtPassword.Text;

            bool any = _carContext.Users.Any(user => user.Password == password && user.Username == userName);

            if (any)
            {
                var main = new Main();
                main.Show();
                Hide();
            }
        }
    }
}
