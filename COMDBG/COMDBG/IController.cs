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
