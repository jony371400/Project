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
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        LogData Log = null;
        Connection Connect = null;
        CmdData Cmd = null;

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;

            Log = new LogData();
            Cmd = new CmdData();
            Connect = new Connection(Log);
            Ports = Connect.Ports;
            Connect.Notice += Notice;
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

        string result = "Off-Line";
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

        string[] ports = null;
        public string[] Ports
        {
            get { return ports; }
            set { ports = value; }
        }
        #endregion

        #region Notice
        void Notice()
        {
            ResultStatus = Connect.ResultStatus;
            Result = Connect.Result;
            IsConnected = Connect.IsConnected;

            if (Connect.IsConnected == false)
                btnConnect.Background = Brushes.LightGray;
            else
                btnConnect.Background = Brushes.LightGreen;
        }
        #endregion

        #region Event
        private void Window_Closed(object sender, EventArgs e)
        {
            Connect.Close();
            Log.SaveLog();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (Connect.Ports != null)
                combobox.SelectedIndex = 0;
            btnCannelConnect.IsEnabled = false;
        }

        private void Connect_Click(object sender, RoutedEventArgs e)
        {
            if (sender == btnConnect)
            {
                if (Connect.IsConnected == false)
                    Connect.Connect(combobox.SelectedIndex);

                btnConnect.IsEnabled = false;
                btnCannelConnect.IsEnabled = true;
                Log.AgvMsg.Add("Connect");
            }
            else if (sender == btnCannelConnect)
            {
                Connect.Close();
                btnConnect.IsEnabled = true;
                btnCannelConnect.IsEnabled = false;
                Log.AgvMsg.Add("DisConnect");
            }
        }

        //暫不啟用
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
                    //if (IsConnected)
                    //    serialPort.Write(buf, 0, 1);
                }
                catch { }
            }
            else if (sender == btnStop)
            {
                btnStop.Background = Brushes.LightGreen;
                try
                {
                    byte[] buf = new byte[1];
                    //if (IsConnected)
                    //    serialPort.Write(buf, 0, 1);
                }
                catch { }
            }else if (sender == btnRight)
            {
                btnStart.Background = Brushes.LightGreen;
                try
                {
                    byte[] buf = new byte[1];
                    //if (IsConnected)
                    //    serialPort.Write(buf, 0, 1);
                }
                catch { }
            }
            else if (sender == btnLeft)
            {
                btnStop.Background = Brushes.LightGreen;
                try
                {
                    byte[] buf = new byte[1];
                    //if (IsConnected)
                    //    serialPort.Write(buf, 0, 1);
                }
                catch { }
            }
        }

        //暫不啟用
        private void DN_Click(object sender, MouseButtonEventArgs e) { }

        //暫不啟用
        private void UP_Click(object sender, MouseButtonEventArgs e) { }

        private void Control_Click(object sender, RoutedEventArgs e)
        {
            btnFront.Background = Brushes.LightGray;
            btnBack.Background = Brushes.LightGray;

            if (sender == btnFront)
            {
                btnFront.Background = Brushes.LightGreen;
                Connect.Command(Cmd.Test, Cmd.Test.Length);
                Log.AgvMsg.Add("Front DN");
            }
            else if (sender == btnBack)
            {
                btnBack.Background = Brushes.LightGreen;
                Connect.Command(Cmd.Test, Cmd.Test.Length);
                Log.AgvMsg.Add("Back DN");
            }
        }
        #endregion

        #region Rendering
        private void btnMouseMoveIn(object sender, MouseEventArgs e)
        {
            if (sender == btnStart)
                btnStart.FontSize = 30;
            else if (sender == btnStop)
                btnStop.FontSize = 30;
            else if (sender == btnFront)
                btnFront.FontSize = 30;
            else if (sender == btnBack)
                btnBack.FontSize = 30;
        }

        private void btnMouseMoveOut(object sender, MouseEventArgs e)
        {
            if (sender == btnStart)
                btnStart.FontSize = 26;
            else if (sender == btnStop)
                btnStop.FontSize = 26;
            else if (sender == btnFront)
                btnFront.FontSize = 26;
            else if (sender == btnBack)
                btnBack.FontSize = 26;
        }
        #endregion

    }
}