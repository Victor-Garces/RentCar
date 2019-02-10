using DevExpress.Xpf.Core;
using DXApplication1.Forms;
using System.Windows.Forms;

namespace DXApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ThemedWindow
    {
        public MainWindow()
        {
            Application.SetCompatibleTextRenderingDefault(false);
            Application.EnableVisualStyles();
            Application.Run(new frmLogin());
        }

        public MainWindow(bool any)
        {
            InitializeComponent();
        }
    }
}
