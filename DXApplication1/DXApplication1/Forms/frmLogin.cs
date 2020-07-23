using Core.Enums;
using DXApplication1.DataLayer;
using DXApplication1.Forms.Views.RentCarContextView;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DXApplication1.Forms
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public static UserRole Role { get; set; }

        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new RentCarContext())
                {
                    string username = usernameText.Text;
                    string password = RentCarContext.EncryptString(passwordText.Text);

                    var currentUser = context.Users.FirstOrDefault(user => user.Username == username && user.Password == password);

                    if (currentUser != null && currentUser.IsActive)
                    {
                        Hide();
                        Role = currentUser.Rol;
                        var mainWindow = new RentCarContextView();
                        DevExpress.XtraEditors.XtraDialog.Show(mainWindow);
                    }
                    else if (currentUser != null && !currentUser.IsActive)
                    {
                        MessageBox.Show("Usuario desactivado", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Credenciales incorrectas", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch(Exception)
            {
                var mainWindow = new RentCarContextView();
                DevExpress.XtraEditors.XtraDialog.Show(mainWindow);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}