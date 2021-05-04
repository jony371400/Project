﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MG100
{
    public class CmdData
    {
        //Music
        public byte[] MP3_34 = { 0x4a, 0x01, 0x07, 0x40, 0x34, 0x44, 0x7c };
        public byte[] MP3_27 = { 0x4a, 0x01, 0x07, 0x40, 0x27, 0x44, 0x6f };

        //Control
        //Stop
        public byte[] EmgStop = { 0X4a, 0X01, 0X07, 0X23, 0X02, 0X44, 0X29 };
        public byte[] CarStop1 = { 0X4a, 0X01, 0X07, 0X23, 0X0E, 0X44, 0X25 }; 
        public byte[] CarStop2 = { 0X4a, 0X01, 0X07, 0X23, 0X0F, 0X44, 0X24 };

        //Act
        //往後走
        public byte[] Back = { 0x4a, 0x01, 0x09, 0x23, 0x06, 0x23, 0x01, 0X44, 0X01 };
        //往前走
        public byte[] Front = { 0x4a, 0x01, 0x09, 0x23, 0x05, 0x23, 0x01, 0X44, 0X02 };        
        //向左轉90度
        byte[] R90 = { 0x4A, 0x01, 0x07, 0x23, 0x11, 0x44, 0x3A };
        //向右轉90度
        byte[] L90 = { 0x4A, 0x01, 0x07, 0x23, 0x12, 0x44, 0x39 };
        //向右180度
        byte[] R180 = { 0x4A, 0x01, 0x09, 0x23, 0x11, 0x23, 0x11, 0x44, 0x06 };
        //向左180度
        byte[] L180 = { 0x4A, 0x01, 0x09, 0x23, 0x12, 0x23, 0x12, 0x44, 0x06 };

        //Setting
        //沿右軌行走 一律正行
        byte[] RW = { 0x4A, 0x01, 0x07, 0x23, 0x16, 0x44, 0x3D };
        //沿左軌行走 一律正行
        byte[] LW = { 0x4A, 0x01, 0x07, 0x23, 0x17, 0x44, 0x3C };
        //沿中軌行走 一律正行
        byte[] MW = { 0x4A, 0x01, 0x07, 0x23, 0x18, 0x44, 0x33 };
        //高速
        byte[] HS = { 0x4A, 0x01, 0x07, 0x23, 0x0B, 0x44, 0x20 };
        //中速
        byte[] MS = { 0x4A, 0x01, 0x07, 0x23, 0x0C, 0x44, 0x27 };
        //低速
        byte[] LS = { 0x4A, 0x01, 0x07, 0x23, 0x0D, 0x44, 0x26 };
        //開啟IR
        //關閉IR
        
        //Mannul
        //單動往前
        //單動往後
        //單動往左
        //單動往右
    }
}