using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace keyboard_tester
{
    public partial class Form1 : Form
    {
        public delegate void AddDataDelegate(String myString);
        public AddDataDelegate myDelegate;
        string oldPortName = "";
        string portName="";
        bool openPortText = true;
        public Form1()
        {
            InitializeComponent();
            this.myDelegate = new AddDataDelegate(AddDataMethod);
            updatePortList();
        }

        private void updatePortName(){
            if (portList.Items.Contains(portName))
            {
                portList.SelectedItem = portName;
            }
            else
            {
                portName = "";
            }
            
        }
        private void updatePortList()
        {
            //toLog("updatePortList\n");
            bool once = true;
            string[] ports = SerialPort.GetPortNames();
            portList.Items.Clear();
            once = true;
            foreach (string port in ports)
            {
                if (once || port != portName)
                {
                    portList.Items.Add(port);
                }
                if(port == portName)
                {
                    once = false;
                }
            }
            
        }
        public bool portNameChanged()
        {
            int index = portList.SelectedIndex;
            if (index >= 0)
            {
                portName = portList.Items[index].ToString();
            }
            if (portName != oldPortName)
            {
                oldPortName = portName;
                return true;
            }
            return false;
        }
        private void reopenPort()
        {
            closePort();
            openPort();
        }
        private void checkPortState()
        {

            Online.Value = serialPort1.IsOpen ? 100 : 0;

        }
        private void timer2sec_Tick(object sender, EventArgs e)
        {
            updatePortList();
            updatePortName();
            if (portNameChanged()){
                reopenPort();
            }
            if (!serialPort1.IsOpen && openPortCheckbox.Checked)
            {
                //toLog(portName+"has been disconnected!!!\n");
                closePort();
                openPort();
            }
            checkPortState();
        }
        private void portList_SelectedValueChanged(object sender, EventArgs e)
        {
            // обновить название порта
            // закрыть старый и открыть новый порт
            if (portNameChanged())
            {
                reopenPort();
            }
        }
        private void openPortCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (openPortCheckbox.Checked)
            {
                openPort();
            }
            else
            {
                closePort();
            }
        }
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string s = sp.ReadExisting();
            log.Invoke(this.myDelegate, new Object[] { s });
        }
        public void AddDataMethod(String myString)
        {

            toLog(myString);
        }
        public void closePort()
        {
            serialPort1.Close();
            if (!openPortText)
            {
                toLog("Port closed\n", Color.Tomato);
                openPortText = true;
            }
        }
        public void openPort()
        {
            if (portName != "" && openPortCheckbox.Checked)
            {
                serialPort1.PortName = portName;
                try
                {
                    serialPort1.Open();
                    openPortText = false;
                    toLog("Port " + portName + " open\n", Color.Tomato);
                }
                catch (Exception exc)
                {
                    //Console.WriteLine("Error opening port: {0}", ex.Message);
                }
                
            }
        }


        private void toLog(string s, Color ? color = null)
        {

            log.SelectionColor = color ?? Color.Silver;
            log.AppendText(s);
            log.ScrollToCaret();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
