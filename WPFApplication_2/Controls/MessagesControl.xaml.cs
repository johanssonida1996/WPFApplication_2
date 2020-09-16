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
    /// Interaction logic for MessagesControl.xaml
    /// </summary>
    public partial class MessagesControl : UserControl
    {
        public MessagesControl()
        {
            InitializeComponent();
        }

        public ImageSource MessagesImage
        {
            get { return messagesImage.Source; }
            set { messagesImage.Source = value; }
        }

        public string MessagesName
        {
            get { return messagesName.Text; }
            set { messagesName.Text = value; }
        }

        public string MessagesInfo
        {
            get { return messagesInfo.Text; }
            set { messagesInfo.Text = value; }
        }
    }
}
