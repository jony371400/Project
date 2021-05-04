using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MG100
{
    public class LogData
    {
        string Road = "";
        public List<string> AgvMsg = new List<string>();

        public LogData()
        {
            string Env = Environment.CurrentDirectory;
            string Time = DateTime.Now.ToString("MMddHHmm");
            Road = Env + "\\Log\\" + Time + ".txt";
        }

        public void SaveLog()
        {
            StreamWriter sw = new StreamWriter(Road);
            foreach (string msg in AgvMsg)
                sw.WriteLine(msg);
            sw.Close();
        }
    }
}