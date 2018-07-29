using System;
using System.IO.Ports;

namespace SerialPortTest
{
    class Program
    {
        //Create a main serial port class
        static SerialPort LWSP;
        static void Main(string[] args)
        {
            LWSP = new SerialPort();
            LWSP.PortName = "com5"; // Check device manager to find out your com port
            LWSP.BaudRate = 9600;   //Integer 9600
            LWSP.ReadTimeout = 5000;
            //Very important to enable RTS on both sides for this to work in C#
            LWSP.RtsEnable = true;
            LWSP.Open();

            while (true)
            {
                //Console.WriteLine(DateTime.Now.ToString() + " : " + LWSP.ReadLine());
                Console.WriteLine(LWSP.ReadLine());
            }

        }
    }
}
