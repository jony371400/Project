using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace MG100
{
    public delegate void NoticeEvent();
    public class Connection
    {
        public SerialPort serialPort = new SerialPort();
        public event NoticeEvent Notice;
        LogData Log = null;

        public Connection(LogData _Log)
        {
            Log = _Log;
            ports = SerialPort.GetPortNames();
            serialPort.DataReceived += serialPort_DataReceived;
        }

        #region Property
        bool isConnected = false;
        public bool IsConnected
        {
            get { return isConnected; }
            set { isConnected = value; }
        }

        string result = "Off-Line";
        public string Result
        {
            get { return result; }
            set { result = value; }
        }

        string resultStatus = "Message";
        public string ResultStatus
        {
            get { return resultStatus; }
            set { result = value; }
        }

        string[] ports = null;
        public string[] Ports
        {
            get { return ports; }
            set { ports = value; }
        }
        #endregion

        public void Connect(int index)
        {
            try
            {
                serialPort.PortName = Ports[index];
                serialPort.BaudRate = 9600;
                serialPort.DataBits = 8;
                serialPort.StopBits = StopBits.One;
                serialPort.Open();

                Status(true, "Success");
            }
            catch
            {
                Status(false , "Fail");
            }

            Notice();
        }

        public void Command(byte[] buffer, int count)
        {
            try
            {
                //if (IsConnected)
                    serialPort.Write(buffer, 0, count);
            }
            catch (Exception ex)
            {
                var msg = ex.Message.ToString();
            }
        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            Byte[] buffer = new Byte[1024];
            int Len = sp.Read(buffer, 0, buffer.Length);
            Array.Resize(ref buffer, Len);

            string str = "";
            foreach (Byte b in buffer)
            {
                str += b.ToString("X2");
                str += ",";
            }
            ResultStatus = str;
            Notice();
        }

        public void Close()
        {
            serialPort.Close();
        }

        void Status(bool _IsConnected, string _Msg)
        {
            IsConnected = _IsConnected;
            Result = _Msg;
            Log.AgvMsg.Add(_Msg);
        }
    }
}