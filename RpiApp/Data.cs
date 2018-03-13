using System;
using System.IO;
using System.Collections.Generic;
using Raspberry.IO.GeneralPurpose;
using Raspberry.IO;
namespace RpiApp
{

}
public class Data

{
    public class TempSensor : Data,IInputOutputBinaryPin // класс датчика температуры
   {
        public TempSensor()
        { }

        ConnectorPin TempPin;

        public ConnectorPin ConnectorPinDetector(int IncomingPort)//gets number of the port from user and assigns real port
        {
            //3 5 7 8  10 11 12 13 15 16 18 19 21 22 23 24 26 27 28 29 31 32 33 35 36 37 38 40 its phisical location
            ConnectorPin pin = ConnectorPin.P1Pin3;
            switch(IncomingPort)
            {
                case 3:
                    pin = ConnectorPin.P1Pin3;
                    break;
                case 5:
                    pin = ConnectorPin.P1Pin5;
                    break;
                case 7:
                    pin = ConnectorPin.P1Pin7;
                    break;
                case 8:
                    pin = ConnectorPin.P1Pin8;
                    break;
                case 10:
                    pin = ConnectorPin.P1Pin10;
                    break;
                case 11:
                    pin = ConnectorPin.P1Pin11;
                    break;
                case 12:
                    pin = ConnectorPin.P1Pin12;
                    break;
                case 13:
                    pin = ConnectorPin.P1Pin13;
                    break;
                case 15:
                    pin = ConnectorPin.P1Pin15;
                    break;
                case 16:
                    pin = ConnectorPin.P1Pin16;
                    break;
                case 18:
                    pin = ConnectorPin.P1Pin18;
                    break;
                case 19:
                    pin = ConnectorPin.P1Pin19;
                    break;
                case 21:
                    pin = ConnectorPin.P1Pin21;
                    break;
                case 22:
                    pin = ConnectorPin.P1Pin22;
                    break;
                case 23:
                    pin = ConnectorPin.P1Pin23;
                    break;
                case 24:
                    pin = ConnectorPin.P1Pin24;
                    break;
                case 26:
                    pin = ConnectorPin.P1Pin26;
                    break;
                case 27:
                    pin = ConnectorPin.P1Pin27;
                    break;
                case 28:
                    pin = ConnectorPin.P1Pin28;
                    break;
                case 29:
                    pin = ConnectorPin.P1Pin29;
                    break;
                case 31:
                    pin = ConnectorPin.P1Pin31;
                    break;
                case 32:
                    pin = ConnectorPin.P1Pin32;
                    break;
                case 33:
                    pin = ConnectorPin.P1Pin33;
                    break;
                case 35:
                    pin = ConnectorPin.P1Pin35;
                    break;
                case 36:
                    pin = ConnectorPin.P1Pin36;
                    break;
                case 37:
                    pin = ConnectorPin.P1Pin37;
                    break;
                case 38:
                    pin = ConnectorPin.P1Pin38;
                    break;
                case 40:
                    pin = ConnectorPin.P1Pin40;
                    break;

            }
            return pin;
        }

        public bool TempSensorConnection(ConnectorPin Pin)
        {
            bool IsConnected = false;
            try
            {
                TemperaturePin pin = new TemperaturePin();
                using (Raspberry.IO.Components.Sensors.Temperature.Dht.Dht22Connection dht22Connection = new Raspberry.IO.Components.Sensors.Temperature.Dht.Dht22Connection(pin))
                {

                    Raspberry.IO.Components.Sensors.Temperature.Dht.DhtData data = new Raspberry.IO.Components.Sensors.Temperature.Dht.DhtData();
                    data = dht22Connection.GetData();

                }

                
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

        public void AsInput()
        {
            TempPin.Input();

            throw new NotImplementedException();
        }

        public void AsOutput()
        {
            throw new NotImplementedException();
        }

        public bool Read()
        {
            throw new NotImplementedException();
        }

        public void Wait(bool waitForUp = true, TimeSpan timeout = default(TimeSpan))
        {
            throw new NotImplementedException();
        }

        public void Write(bool state)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}