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

namespace MG100
{
    public partial class Sensor : UserControl
    {
        public Sensor()
        {
            InitializeComponent();
        }

        public void Changing(bool variable) //判斷啟動值 (true綠燈 / false紅燈)
        {
            if (variable == true)
                ep.Fill = Brushes.LightGreen;
            else if (variable == false)
                ep.Fill = Brushes.Gray;
        }

        public void Alarm(bool alarm)
        {
            if (alarm == true)
                ep.Fill = Brushes.Red;
            else if (alarm == false)
                ep.Fill = Brushes.Gray;
        }
    }
}