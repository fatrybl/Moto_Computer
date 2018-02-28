using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Raspberry.IO.GeneralPurpose;
using Raspberry.IO.Components;

namespace RpiApp
{

    }
public class Data
{
    public class TempSensor : Data // класс датчика температуры
   {
        public TempSensor()
        {}       
        private IGpioConnectionDriver driver;
        public bool TempSensorConnection(int PinNumber)
        {
            bool IsConnected = false;
            try
            {
                GpioInputOutputBinaryPin TempPin = new GpioInputOutputBinaryPin(driver, ProcessorPin.Pin11);
                Raspberry.IO.Components.Sensors.Temperature.Dht.Dht11Connection dht11Connection = new Raspberry.IO.Components.Sensors.Temperature.Dht.Dht11Connection(TempPin);
                TempPin.AsInput();
                dht11Connection.Start();
                IsConnected = true;
                Console.WriteLine("Connection has been established and Pin is declared ");
            }

            catch (Exception ex)
            {
                Console.WriteLine("Cant establish connection or declare Pin " + ex.Message);
            }
            finally
            {
                Console.WriteLine("work witch connections is finished ");
            }

            return IsConnected;

        }
        public double GetTempSensorData(GpioInputOutputBinaryPin TempPin)//считывает данные с датчика температуры, сохраняет последние 200 изменений в файл и ОЗУ.
        {
            double TempData = 0;
            Console.WriteLine("Pin11 is connected and gets Data ");
            bool d = false;
            d = TempPin.Read();
            if (d == true) { TempData = 1; }
            else { TempData = 0; }
            return TempData;
        }
        public bool WriteDataToFile(double[] Data)
        {
            bool IsWritten = false;
            try
            {
                if (Data != null)
                {
                    StreamWriter writer = new StreamWriter("TempSensorData.txt",false);

                    foreach (double element in Data)
                    {
                        writer.WriteLine(element.ToString());
                    }
                    IsWritten = true;
                    writer.Flush();
                    writer.Close();
                }
                else { Console.WriteLine(" NULL data came to WriteDataToFile function !"); }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Can`t write in file " + ex.Message);
            }
            finally
            {
                if (IsWritten == true)
                { Console.WriteLine("Work with file has been finished successfully "); }
                else
                {
                    Console.WriteLine("Work with file has been finished unsuccessfully ");
                };
            }
            return IsWritten;
        }
        public List<double> ReadDataFromFile(string FileName)
        {
            bool IsRead = false;
            List<double> DataFromFile = new List<double> { };
            try
            {
                if (File.Exists(FileName))
                {
                    double value;
                    string[] StringsFromFile = File.ReadAllLines(FileName);
                    foreach (string line in StringsFromFile)
                    {
                        //Console.WriteLine("\t" + line);
                        if (double.TryParse(line, out value))
                        {
                            DataFromFile.Add(value);
                            //DataFromFile.ForEach(Console.WriteLine);
                        }
                    }
                    IsRead = true;
                }
                else { Console.WriteLine("the " + FileName + " does not exist"); }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Can`t read from  file because " + ex.Message);
            }
            finally
            {
                if (IsRead == true)
                { Console.WriteLine("Work with file has been finished successfully "); }
                else
                {
                    Console.WriteLine("Work with file has been finished unsuccessfully ");
                };
            }
            return DataFromFile;
        }
    }
}
    

