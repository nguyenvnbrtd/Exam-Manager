﻿using System;
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

namespace ExamManager.UScontrol
{
    /// <summary>
    /// Interaction logic for AddExam.xaml
    /// </summary>
    public partial class AddExam : UserControl
    {
        public AddExam()
        {
            try { InitializeComponent(); } catch { }
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            AddingExam ad = new AddingExam();
            ad.ShowDialog();
        }
    }
}
