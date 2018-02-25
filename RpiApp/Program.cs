using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RpiApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());


            Data.TempSensor tempSensor = new Data.TempSensor();
            tempSensor.TempSensorConnection(11);
            double[] array = { 0, 1.5, 2.46, 3, 4, 5 };
            if (tempSensor.WriteDataToFile(array))
            {
                double[] arr = tempSensor.ReadDataFromFile("TempSensorData.txt");
                foreach (double element in arr)
                {
                    Console.WriteLine(element + "\n");
                }
            }
            else Console.WriteLine("sukablyat");
        }
    }
}
