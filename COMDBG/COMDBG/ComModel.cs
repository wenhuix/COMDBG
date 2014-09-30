using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;

namespace COMDBG
{
    public delegate void SerialPortEventHandler(Object sender, SerialPortEventArgs e);

    public class SerialPortEventArgs : EventArgs
    {
        public bool isOpend = false;
        public String receivedString = "";
    }

    public class ComModel
    {
        private SerialPort sp = new SerialPort();

        public event SerialPortEventHandler comReceiveDataEvent = null;
        public event SerialPortEventHandler comOpenEvent = null;
        public event SerialPortEventHandler comCloseEvent = null;

        /// <summary>
        /// When serial received data, will call this method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            while (sp.BytesToRead > 0)
            {
                SerialPortEventArgs args = new SerialPortEventArgs();
                string str = sp.ReadExisting();
                args.receivedString = str;
                comReceiveDataEvent.Invoke(this, args);
            }
        }

        public void Send(Byte[] bytes)
        {
            if (sp.IsOpen)
            {
                sp.Write(bytes, 0, bytes.Length);
            }
        }

        /// <summary>
        /// Open Serial port
        /// </summary>
        /// <param name="portName"></param>
        /// <param name="baudRate"></param>
        /// <param name="dataBits"></param>
        /// <param name="stopBits"></param>
        /// <param name="parity"></param>
        public void Open(string portName, String baudRate,
            string dataBits, string stopBits, string parity)
        {
            if (sp.IsOpen)
            {
                sp.Close();
            }
            sp.PortName = portName;
            sp.BaudRate = Convert.ToInt32(baudRate);
            sp.DataBits = Convert.ToInt16(dataBits);
            sp.StopBits = (StopBits)Enum.Parse(typeof(StopBits), stopBits);
            sp.Parity = (Parity)Enum.Parse(typeof(Parity), parity);

            SerialPortEventArgs args = new SerialPortEventArgs();
            try
            {
                sp.Open();
                sp.DataReceived += new SerialDataReceivedEventHandler(DataReceived);
                args.isOpend = true;
            }
            catch (System.Exception ex)
            {
                args.isOpend = false;
            }
            comOpenEvent.Invoke(this, args);
        }

        /// <summary>
        /// Close serial port
        /// </summary>
        public void Close()
        {
            SerialPortEventArgs args = new SerialPortEventArgs();
            if (sp.IsOpen)
            {
                sp.Close();
                args.isOpend = false;
            }
            comCloseEvent.Invoke(this, args);
        }
    }
}
