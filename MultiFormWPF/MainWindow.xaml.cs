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

namespace MultiFormWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}

// on the Designer XAML just before xmlns:local add:
//xmlns:...="clr-namespace:OtherNamespace"; assembly=OtherNamespace"
//On the Designer XAML just before the grid ending add:
//< ...:UserControl1 VerticalContentAlignment="Center"></...:UserControl1>
//< ...:UserControl1 VerticalContentAlignment="Center" Grid.Column="1"></...:UserControl1>
//< ...:UserControl1 VerticalContentAlignment="Center" Grid.Row="1"></...:UserControl1>
//< ...:UserControl1 VerticalContentAlignment="Center" Grid.Column="1"></...:UserControl1>