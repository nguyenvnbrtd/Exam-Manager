using ExamManager.Model;
using ExamManager.UScontrol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ExamManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Home h1;
        Candidate c1;
        Result r1;
        ListCandidate l1;
        AddExam a1;
        
        public MainWindow()
        {
            InitializeComponent();
            mainWindow.Hide();

            DataProvider.Ins.DB.Users.ToList();
            LoginWindow lg = new LoginWindow();
            

            lg.ShowDialog();
            try {
                h1 = new Home();
                c1 = new Candidate();
                r1 = new Result();
                l1 = new ListCandidate();
                a1 = new AddExam();
                mainWindow.Show();
                
            } catch { }
           
        }

        private void ListVeiwMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = listVeiwMenu.SelectedIndex;
            MoveCusorMenu(index);
            

            switch (index) {
                case 0:
                    mainGrid.Children.Clear();
                    mainGrid.Children.Add(h1);
                    break;
                case 1:
                   
                    mainGrid.Children.Clear();
                    mainGrid.Children.Add(c1);
                    break;
                case 2:
                    mainGrid.Children.Clear();
                    mainGrid.Children.Add(r1);
                    break;
                case 3:
                    mainGrid.Children.Clear();
                    mainGrid.Children.Add(l1);

                    break;
                case 4:
                    mainGrid.Children.Clear();
                    mainGrid.Children.Add(a1);
                    break;
                default:
                    mainGrid.Children.Clear();
                    break;
            }
            
        }
       

        private void MoveCusorMenu(int index)
        {
            
            gridSeclected.Margin = new Thickness(0,66*index,0,0);
        }

        

        private void ListVeiwMenu_Loaded(object sender, RoutedEventArgs e)
        {
            mainGrid.Children.Add(h1);
        }

        private void PackIcon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
