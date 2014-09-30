using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Windows.Forms;

namespace COMDBG
{
    public interface IView
    {
        void SetController(IController controller);
        void OpenComEvent(Object sender, SerialPortEventArgs e);
        void CloseComEvent(Object sender, SerialPortEventArgs e);
        void ComReceiveDataEvent(Object sender, SerialPortEventArgs e);
    }

    public partial class MainForm : Form, IView
    {
        private IController controller;
        private string lastPortName = null;
        private int sendBytesCount = 0;
        private int receiveBytesCount = 0;

        public MainForm()
        {
            InitializeComponent();
            InitializeCOMCombox();
            this.statusTimeLabel.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            this.RxTbx.Text = "0";
            this.TxTbx.Text = "0";
        }

        public void SetController(IController controller)
        {
            this.controller = controller;
        }

        /// <summary>
        /// update status bar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OpenComEvent(Object sender, SerialPortEventArgs e)
        {
            if (e.isOpend)
            {
                statuslabel.Text = "Opend";
                openCloseSpbtn.Text = "Close";
            } 
            else
            {
                statuslabel.Text = "Open failed!";
            }
        }

        /// <summary>
        /// update status bar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void CloseComEvent(Object sender, SerialPortEventArgs e)
        {
            if (!e.isOpend)
            {
                statuslabel.Text = "Closed";
                openCloseSpbtn.Text = "Open";
            }
        }

        /// <summary>
        /// Display received data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ComReceiveDataEvent(Object sender, SerialPortEventArgs e)
        {
            if (recStrRadiobtn.Checked)
            {
                receivetbx.Text += e.receivedString;
            } 
            else
            {
                receivetbx.Text += e.receivedBytes;
            }
            receiveBytesCount += e.receivedBytes.Length;
            RxTbx.Text = receiveBytesCount.ToString();
        }


        /// <summary>
        /// Initialize serial port infomation
        /// </summary>
        private void InitializeCOMCombox()
        {
            //BaudRate
            baudRateCbx.Items.Add(4800);
            baudRateCbx.Items.Add(9600);
            baudRateCbx.Items.Add(19200);
            baudRateCbx.Items.Add(38400);
            baudRateCbx.Items.Add(57600);
            baudRateCbx.Items.Add(115200);
            baudRateCbx.Items.ToString();
            //get 9600 print in text
            baudRateCbx.Text = baudRateCbx.Items[1].ToString();

            //Data bits
            dataBitsCbx.Items.Add(7);
            dataBitsCbx.Items.Add(8);
            //get the 8bit item print it in the text 
            dataBitsCbx.Text = dataBitsCbx.Items[1].ToString();

            //Stop bits
            stopBitsCbx.Items.Add("One");
            stopBitsCbx.Items.Add("OnePointFive");
            stopBitsCbx.Items.Add("Two");
            //get the One item print in the text
            stopBitsCbx.Text = stopBitsCbx.Items[0].ToString();

            //Parity
            parityCbx.Items.Add("None");
            parityCbx.Items.Add("Even");
            parityCbx.Items.Add("Mark");
            parityCbx.Items.Add("Odd");
            parityCbx.Items.Add("Space");
            //get the first item print in the text
            parityCbx.Text = parityCbx.Items[0].ToString();

            string[] ArrayComPortsNames = null;

            //Com Ports
            ArrayComPortsNames = SerialPort.GetPortNames();
            if (ArrayComPortsNames.Length == 0)
            {
                MessageBox.Show("No Serial port found！");
                return;
            }
            else
            {
                Array.Sort(ArrayComPortsNames);
                for (int i = 0; i < ArrayComPortsNames.Length; i++)
                {
                    comListCbx.Items.Add(ArrayComPortsNames[i]);
                }
            }
            comListCbx.Text = ArrayComPortsNames[0];
        }

        /// <summary>
        /// update time in status bar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void statustimer_Tick(object sender, EventArgs e)
        {
            this.statusTimeLabel.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
        }

        /// <summary>
        /// open or close serial port
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openCloseSpbtn_Click(object sender, EventArgs e)
        {
            if (openCloseSpbtn.Text == "Open")
            {
                lastPortName = comListCbx.Text;
                controller.OpenSerialPort(comListCbx.Text, baudRateCbx.Text,
                    dataBitsCbx.Text, stopBitsCbx.Text, parityCbx.Text);
            } 
            else
            {
                controller.CloseSerialPort();
            }
        }

        /// <summary>
        /// Send data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sendbtn_Click(object sender, EventArgs e)
        {
            controller.SendData(sendtbx.Text);
            if (sendtbx.Text != null)
            {
                sendBytesCount += sendtbx.Text.Length;
                TxTbx.Text = sendBytesCount.ToString();
            }
        }

        /// <summary>
        /// clear text in send area
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearSendbtn_Click(object sender, EventArgs e)
        {
            sendtbx.Text = "";
            TxTbx.Text = "0";
            sendBytesCount = 0;
        }

        /// <summary>
        /// clear receive text in receive area
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearReceivebtn_Click(object sender, EventArgs e)
        {
            receivetbx.Text = "";
            RxTbx.Text = "0";
            sendBytesCount = 0;
        }

        /// <summary>
        /// Save received data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveFileDialog.Filter = "txt file|*.txt";
            saveFileDialog.DefaultExt = ".txt";
            saveFileDialog.FileName = "received.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                String fName = saveFileDialog.FileName;
                System.IO.File.WriteAllText(fName, receivetbx.Text);
            }
        }

        /// <summary>
        /// about me
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.StartPosition = FormStartPosition.CenterParent;
            about.Show();

            if (about.StartPosition == FormStartPosition.CenterParent)
            {
                var x = Location.X + (Width - about.Width) / 2;
                var y = Location.Y + (Height - about.Height) / 2;
                about.Location = new Point(Math.Max(x, 0), Math.Max(y, 0));
            }

        }
    }
}
