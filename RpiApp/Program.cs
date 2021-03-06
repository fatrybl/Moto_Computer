﻿using System;
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            TempSensorForm sensorForm = new TempSensorForm();
            Application.Run(sensorForm);
 
            Data.TempSensor tempSensor =new Data.TempSensor();
            //tempSensor.AsInput(); // activating temperature pin
            //tempSensor.Read(); // start getting temperature and humadity data

            tempSensor.PinNumber = sensorForm.PinNumber;

            Console.WriteLine("      "+tempSensor.PinNumber+ "      ");
            //double[] array = { 0, 1.5, 2.46, 3, 4, 5 };
            //List<double> list = new List<double> { };
            //foreach (double element in array)
            //{ list.Add(element); }
            //tempSensor.WriteDataToFile(array);
            //List<double> tmp = new List<double> { };
            //tmp=tempSensor.ReadDataFromFile("TempSensorData.txt");
            //tmp.ForEach(Console.WriteLine);
        }
    }
}
