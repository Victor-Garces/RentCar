using DXApplication1.DataLayer;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DXApplication1.Forms
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new RentCarContext())
            {
                string username = usernameText.Text;
                string password = passwordText.Text;

                var any = context.Users.Any(user => user.Username == username && user.Password == password && user.IsActive);

                if (any)
                {
                    Hide();
                    var mainWindow = new MainWindow(false);
                    mainWindow.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Credenciales incorrectas", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}