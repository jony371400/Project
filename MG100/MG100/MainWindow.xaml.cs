using System;
using System.IO;
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
using System.ComponentModel;
using System.IO.Ports;

namespace MG100
{
    public partial class MainWindow : Window,INotifyPropertyChanged
    {
        SerialPort serialPort = new SerialPort();
        CmdData Cmd = new CmdData();
        LogData Log = new LogData();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;

            //Communication
            ports = SerialPort.GetPortNames();
            serialPort.DataReceived += serialPort_DataReceived;
        }

        #region Update
        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
        
        #region Property
        bool IsConnected = false;

        string[] ports = null;
        public string[] Ports
        {
            get { return ports; }
        }

        string result = "Status";
        public string Result
        {
            get { return result; }
            set
            {
                result = value;
                NotifyPropertyChanged("Result");
            }
        }

        string resultstatus = "Result Status";
        public string ResultStatus
        {
            get { return resultstatus; }
            set
            {
                resultstatus = value;
                NotifyPropertyChanged("ResultStatus");
            }
        }
        #endregion

        #region Event
        private void Window_Closed(object sender, EventArgs e)
        {
            serialPort.Close();
            Log.SaveLog();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (ports != null)
                combobox.SelectedIndex = 0;
        }

        private void Connect_Click(object sender, RoutedEventArgs e)
        {
            if (ports == null)
                return;
            try
            {
                serialPort.PortName = ports[combobox.SelectedIndex];
                serialPort.BaudRate = 9600;
                serialPort.DataBits = 8;
                serialPort.StopBits = StopBits.One;
                serialPort.Open();
                Result = "Success";
                Sensor.Background = Brushes.LightGreen;
                IsConnected = true;
            }
            catch
            {
                Result = "Fail";
                Sensor.Background = Brushes.Red;
            }
        }

        private void Cmd_Click(object sender, RoutedEventArgs e)
        {
            btnStart.Background = Brushes.LightGray;
            btnStop.Background = Brushes.LightGray;
            if (sender == btnStart)
            {
                btnStart.Background = Brushes.LightGreen;
                try
                {
                    byte[] buf = new byte[1];
                    //buf[0] = brightness;
                    if (IsConnected)
                        serialPort.Write(buf, 0, 1);
                }
                catch { }
            }
            else if (sender == btnStop)
            {
                btnStop.Background = Brushes.LightGreen;
                try
                {
                    byte[] buf = new byte[1];
                    //buf[0] = brightness;
                    if (IsConnected)
                        serialPort.Write(buf, 0, 1);
                }
                catch { }
            }
        }      

        private void DN_Click(object sender, MouseButtonEventArgs e)
        {
            if (sender == btnUP)
            {
                btnUP.Background = Brushes.LightGreen;
                try
                {
                    byte[] buf = new byte[1];
                    buf[0] = Cmd.Front[0];
                    if (IsConnected)
                        serialPort.Write(Cmd.Front, 0, Cmd.Front.Length);
                }
                catch { }
            }
            else if (sender == btnDN)
            {
                btnDN.Background = Brushes.LightGreen;
                try
                {
                    byte[] buf = new byte[1];
                    buf[0] = Cmd.Back[0];
                    if (IsConnected)
                        serialPort.Write(Cmd.Back, 0, Cmd.Back.Length);
                }
                catch { }
            }
        }

        private void UP_Click(object sender, MouseButtonEventArgs e)
        {
            if (sender == btnUP)
            {
                btnUP.Background = Brushes.LightGray;                
            }
            else if (sender == btnDN)
            {
                btnDN.Background = Brushes.LightGray;
            }
            //try
            //{
            //    byte[] buf = new byte[1];
            //    buf[0] = data.Stop1[0];
            //    if (IsConnected)
            //        serialPort.Write(buf, 0, 1);
            //}
            //catch { }
        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            Byte[] buffer = new Byte[1024];
            int Len = sp.Read(buffer, 0,buffer.Length);
            Array.Resize(ref buffer, Len);

            string str = "";
            foreach(Byte b in buffer)
            {
                str += b.ToString("X2");
                str += ",";
            }
            ResultStatus = str;
            Log.AgvMsg.Add(ResultStatus);
        }
        #endregion

        #region Rendering
        private void btnMouseMoveIn(object sender, MouseEventArgs e)
        {
            if (sender == btnStart)
                btnStart.FontSize = 30;
            else if (sender == btnStop)
                btnStop.FontSize = 30;
            else if (sender == btnUP)
                btnUP.FontSize = 30;
            else if (sender == btnDN)
                btnDN.FontSize = 30;
        }

        private void btnMouseMoveOut(object sender, MouseEventArgs e)
        {
            if (sender == btnStart)
                btnStart.FontSize = 26;
            else if (sender == btnStop)
                btnStop.FontSize = 26;
            else if (sender == btnUP)
                btnUP.FontSize = 26;
            else if (sender == btnDN)
                btnDN.FontSize = 26;
        }
        #endregion
    }
}