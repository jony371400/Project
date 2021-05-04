using System;
using System.Collections.Generic;

namespace ByteTest
{
    class Program
    {
        static void Main(string[] args)
        {
            CommandLine CMD = new CommandLine();
            var x = CMD.Code[0];

            byte[] Indexbyte = new byte[] { 0x4A, 0x01, 0x07, 0x23, 0x02, 0x44, 0x29 };

            Console.WriteLine(Indexbyte[0] + "/" + Indexbyte.Length);

            byte SumByte = new byte();
            for (int i = 0; i < Indexbyte.Length; i++)
            {
                SumByte += Indexbyte[i];
            }

            Console.WriteLine(SumByte);
            Console.WriteLine("0x{0:X}",SumByte);

            Console.Read();
        }
    }

    public class CommandLine
    {
        #region CMD
        //0x11 向右90度
        //0x12 向左90度
        //0x13 向中90度
        //0x16 向右軌道行走
        //0x17 向左軌道行走
        //0x18 向中軌道行走
        //0x1B 向右轉圈
        //0x1C 向左轉圈     
        //0x0B 高速
        //0x0C 中速
        //0x0D 低速
        //預設 : 向前 向左軌道行走 低速
        #endregion

        public CommandLine()
        {
            Code.Add(Forward);
            Code.Add(Backward);
            Code.Add(R90);
            Code.Add(L90);
            Code.Add(R180);
            Code.Add(L180);
            Code.Add(RW);
            Code.Add(LW);
            Code.Add(MW);
        }

        public List<byte[]> Code = new List<byte[]>();

        //連續往前
        byte[] Forward = { 0x4A, 0x01, 0x09, 0x23, 0x05, 0x23, 0x01, 0x44, 0x02 };
        //連續往後
        byte[] Backward = { 0x4A, 0x01, 0x09, 0x23, 0x06, 0x23, 0x01, 0x44, 0x01 };

        //向左轉90度
        byte[] R90 = { 0x4A, 0x01, 0x07, 0x23, 0x11, 0x44, 0x06 };
        //向右轉90度
        byte[] L90 = { 0x4A, 0x01, 0x07, 0x23, 0x11, 0x44, 0x06 };
        //向右180度
        byte[] R180 = { 0x4A, 0x01, 0x09, 0x23, 0x11, 0x23, 0x11, 0x44, 0x06 };
        //向左180度
        byte[] L180 = { 0x4A, 0x01, 0x09, 0x23, 0x12, 0x23, 0x12, 0x44, 0x06 };

        //沿右軌行走 一律正行
        byte[] RW = { 0x4A, 0x01, 0x09, 0x23, 0x05, 0x23, 0x01, 0x44, 0x01 };
        //沿左軌行走 一律正行
        byte[] LW = { 0x4A, 0x01, 0x09, 0x23, 0x05, 0x23, 0x01, 0x44, 0x01 };
        //沿中軌行走 一律正行
        byte[] MW = { 0x4A, 0x01, 0x09, 0x23, 0x05, 0x23, 0x01, 0x44, 0x01 };

        //暫停
        public byte[] EmgStop = { 0X4a, 0X01, 0X07, 0X23, 0X02, 0X44, 0X29 };
        public byte[] CarStop1 = { 0X4a, 0X01, 0X07, 0X23, 0X0E, 0X44, 0X25 };
        public byte[] CarStop2 = { 0X4a, 0X01, 0X07, 0X23, 0X0F, 0X44, 0X24 };

        //開啟IR
        //關閉IR
        //單動往前
        //單動往後        
    }
}