/**
 
 * Copyright (c) 2014-2015, Wenhuix, All rights reserved.

 * Redistribution and use in source and binary forms, with or without modification, 
 * are permitted provided that the following conditions are met:

 * Redistributions of source code must retain the above copyright notice, 
 * this list of conditions and the following disclaimer.

 * Redistributions in binary form must reproduce the above copyright notice, 
 * this list of conditions and the following disclaimer in the documentation 
 * and/or other materials provided with the distribution.

 * Neither the name of COMDBG nor the names of its contributors may 
 * be used to endorse or promote products derived from this software without 
 * specific prior written permission.
 * 
 * THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
 * AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE 
 * IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE 
 * ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE 
 * LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR 
 * CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF 
 * SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS 
 * INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN 
 * CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
 * ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF 
 * THE POSSIBILITY OF SUCH DAMAGE.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Timers;

namespace COMDBG
{

    public class IController
    {
        ComModel comModel = new ComModel();
        IView view;

        public IController(IView view)
        {
            this.view = view;
            view.SetController(this);
            comModel.comCloseEvent += new SerialPortEventHandler(view.CloseComEvent);
            comModel.comOpenEvent += new SerialPortEventHandler(view.OpenComEvent);
            comModel.comReceiveDataEvent += new SerialPortEventHandler(view.ComReceiveDataEvent);
        }

        /// <summary>
        /// Hex to byte
        /// </summary>
        /// <param name="hex"></param>
        /// <returns></returns>
        private static byte[] FromHex(string hex)
        {
            hex = hex.Replace("-", "");
            byte[] raw = new byte[hex.Length / 2];
            for (int i = 0; i < raw.Length; i++)
            {
                try
                {
                    raw[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
                }
                catch (System.Exception)
                {
                    //Do Nothing
                }
                
            }
            return raw;
        }

        /// <summary>
        /// Hex string to string
        /// </summary>
        /// <param name="hex"></param>
        /// <returns></returns>
        public static String Hex2String(String hex)
        {
            byte[] data = FromHex(hex);
            return Encoding.Default.GetString(data);
        }

        /// <summary>
        /// String to hex string
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static String String2Hex(String str)
        {
            Byte[] data = Encoding.Default.GetBytes(str);
            return BitConverter.ToString(data);
        }

        /// <summary>
        /// Hex string to bytes
        /// </summary>
        /// <param name="hex"></param>
        /// <returns></returns>
        public static Byte[] Hex2Bytes(String hex)
        {
            return FromHex(hex);
        }

        /// <summary>
        /// Bytes to Hex String
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public static String Bytes2Hex(Byte[] bytes)
        {
            return BitConverter.ToString(bytes);
        }

        /// <summary>
        /// send bytes to serial port
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool SendDataToCom(Byte[] data)
        {
            return comModel.Send(data);
        }

        /// <summary>
        /// Send string to serial port
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public bool SendDataToCom(String str)
        {
            if (str != null && str != "")
            {
                return comModel.Send(Encoding.Default.GetBytes(str));
            }
            return true;
        }

        /// <summary>
        /// Open serial port in comModel
        /// </summary>
        /// <param name="portName"></param>
        /// <param name="baudRate"></param>
        /// <param name="dataBits"></param>
        /// <param name="stopBits"></param>
        /// <param name="parity"></param>
        /// <param name="handshake"></param>
        public void OpenSerialPort(string portName, String baudRate,
            string dataBits, string stopBits, string parity, string handshake)
        {
            if (portName != null && portName != "")
            {
                comModel.Open(portName, baudRate, dataBits, stopBits, parity, handshake);
            }
        }

        /// <summary>
        /// Close serial port in comModel
        /// </summary>
        public void CloseSerialPort()
        {
            comModel.Close();
        }

    }
}
