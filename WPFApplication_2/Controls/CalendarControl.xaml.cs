using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFApplication_2.Controls
{
    /// <summary>
    /// Interaction logic for CalendarControl.xaml
    /// </summary>
    public partial class CalendarControl : UserControl
    {
        public CalendarControl()
        {
            InitializeComponent();
        }
        public ImageSource CalendarImage
        {
            get { return calendarImage.Source; }
            set { calendarImage.Source = value; }
        }

        public string CalendrName
        {
            get { return calendarName.Text; }
            set { calendarName.Text = value; }
        }

        public string CalendarInfo
        {
            get { return calendarInfo.Text; }
            set { calendarInfo.Text = value; }
        }
    }
}
