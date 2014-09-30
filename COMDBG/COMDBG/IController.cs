using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;

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
                raw[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
            }
            return raw;
        }

        /// <summary>
        /// Hex to string
        /// </summary>
        /// <param name="hex"></param>
        /// <returns></returns>
        public static String Hex2String(String hex)
        {
            byte[] data = FromHex(hex);
            return Encoding.ASCII.GetString(data);
        }

        /// <summary>
        /// String to hex
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static String String2Hex(String str)
        {
            Byte[] data = Encoding.Default.GetBytes(str);
            return BitConverter.ToString(data);
        }

        /// <summary>
        /// Send data
        /// </summary>
        /// <param name="str"></param>
        public void SendData(String str)
        {
            if (str != null && str != "")
            {
                comModel.Send(Encoding.Default.GetBytes(str));
            }
        }

        /// <summary>
        /// Open serial port in comModel
        /// </summary>
        /// <param name="portName"></param>
        /// <param name="baudRate"></param>
        /// <param name="dataBits"></param>
        /// <param name="stopBits"></param>
        /// <param name="parity"></param>
        public void OpenSerialPort(string portName, String baudRate,
            string dataBits, string stopBits, string parity)
        {
            if (portName != null && portName != "")
            {
                comModel.Open(portName, baudRate, dataBits, stopBits, parity);
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
