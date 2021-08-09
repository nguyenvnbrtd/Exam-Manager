using ExamManager.Model;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace ExamManager
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public static string LoginUserName;
        public LoginWindow()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var a = DataProvider.Ins.DB.Users.Where(p=>p.UserName == tbusername.Text && p.PassWork == tbpassword.Password).Count();
            if (a > 0)
            {
                LoginUserName = tbusername.Text;
                loginWindow.Close();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void LoginWindow_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            loginWindow.DragMove();
        }
    }
}
