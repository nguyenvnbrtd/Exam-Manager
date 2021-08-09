using ExamManager.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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


namespace ExamManager.UScontrol
{
    /// <summary>
    /// Interaction logic for Candidate.xaml
    /// </summary>
    public partial class Candidate : UserControl
    {
        public Candidate()
        {
            try { InitializeComponent();
                var a = new ObservableCollection<User>(DataProvider.Ins.DB.Users);
                List<User> list = a.ToList();
                int ind = -1;

                for (int i = 0; i < list.Count(); i++)
                {
                    if (list[i].UserName == LoginWindow.LoginUserName)
                    {
                        ind = i;
                        break;
                    }
                }
                if (ind != -1)
                {
                    UserName.Text = list[ind].Name;
                    UserGender.Text = list[ind].Gender;
                    UserJob.Text = list[ind].Job;
                    UserOtherInfo.Text = list[ind].MoreInfo;
                    PhoneNum.Text = list[ind].PhoneNumber;
                    BirthDay.SelectedDate = list[ind].BirthDay.Value;

                }
            } catch { }
            
            
        }
    }
}
