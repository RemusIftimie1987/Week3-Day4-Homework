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
using System.Windows.Threading;

namespace MultiFormWPF
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        private Semaphor sem = new Semaphor();
        public UserControl1()
        {
            InitializeComponent();
            DrawSemaphor(sem.getColorOn());

            DispatcherTimer dt = new DispatcherTimer();
            dt.Interval = new TimeSpan(0, 0, 0, 20); //change color every 20 seconds
            dt.Tick += ChangeColor; 
            dt.Start();
        }
        private void ChangeColor(object sender, EventArgs e)
        {
            sem.ChangeColor();
            DrawSemaphor(sem.getColorOn());
        }
        private void DrawSemaphor(int color)
        {
            Color[] colors = { Colors.Red, Colors.Orange, Colors.Green };
            Ellipse el;

            for (int i = 0; i < STCKPMain.Children.Count; i++) //iterate through all semaphor elements
            {
                el = (Ellipse)STCKPMain.Children[i];
                if (i != color) el.Fill = new SolidColorBrush(Colors.Gray);
                else el.Fill = new SolidColorBrush(colors[i]);
            }
        }
    }
}
