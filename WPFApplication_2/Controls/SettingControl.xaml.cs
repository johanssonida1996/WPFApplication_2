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
    /// Interaction logic for SettingControl.xaml
    /// </summary>
    public partial class SettingControl : UserControl
    {
        public SettingControl()
        {
            InitializeComponent();
        }
        public ImageSource SettingImage
        {
            get { return settingImage.Source; }
            set { settingImage.Source = value; }
        }

        public string SettingName
        {
            get { return settingName.Text; }
            set { settingName.Text = value; }
        }

        public string SettingInfo
        {
            get { return settingInfo.Text; }
            set { settingInfo.Text = value; }
        }
    }
}
