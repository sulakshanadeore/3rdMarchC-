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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            StackPanel panel = new StackPanel();
            this.Content = panel;

            Button b = new Button();
            b.Content = "Button1";
            b.HorizontalAlignment = HorizontalAlignment.Left;
            b.Margin = new Thickness(150);
            b.VerticalAlignment = VerticalAlignment.Top;
            b.Width = 75;
            b.Height = 40;
            panel.Children.Add(b);

        }
    }
}
