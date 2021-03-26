using Aplikacja_MEMS.Frame;
using Aplikacja_MEMS.Transmition;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Ports;
using System.Linq;
namespace Aplikacja_MEMS
{
    static class Communication
    {
        public static void Query(byte command)
        {
            byte[] query;
            switch (command)
            {
                case (byte)CmdType.DataSet:
                    query = new byte[12];
                    Array.Clear(query, 0, query.Length);

                    query[0] = (byte)Identificators.SensorBoardId;
                    query[1] = (byte)Identificators.ApplicationId;
                    query[2] = command;
                    Array.Copy(CurrentTime(), 0, query, 3, CurrentTime().Length);
                    query[10] = CheckSum(query, 10);
                    query[11] = (byte)Identificators.FrameEnd;
                    break;

                default:
                    query = new byte[5];
                    Array.Clear(query, 0, query.Length);

                    query[0] = (byte)Identificators.SensorBoardId;
                    query[1] = (byte)Identificators.ApplicationId;
                    query[2] = command;
                    query[3] = CheckSum(query, 3);
                    query[4] = (byte)Identificators.FrameEnd;
                    break;
            }
            
            ComTransmition.SendMessage(query);
        }
        public static byte[] Query(byte command, byte[] parameters)
        {
            byte[] query = new byte[13];
            Array.Clear(query, 0, query.Length);
           
            int complement = 0;

            query[0] = (byte)Identificators.SensorBoardId;
            query[1] = (byte)Identificators.ApplicationId;
            query[2] = command;
            complement = 3;
            switch (command)
            {
                case (byte)CmdType.DataSet:                                              // Ustawienie aktualnej daty i czasu
                    Array.Copy(CurrentTime(), 0, query, 3, CurrentTime().Length);
                    complement = 10;
                    break;

                case (byte)CmdType.WhoAreYou:                                              // Przedstaw się
                    break;

                case (byte)CmdType.SensorCmd:                                              // Wykonaj...
                    query[3] = parameters[0];                                              // Subkomenda
                    query[4] = parameters[1];                                              // Czujnik
                    switch (parameters[0])
                    {
                        case (byte)SubCmdType.GetAvaliableSensorList:                                      // Podaj listę dostępnych sensorów
                            complement = 5;
                            break;
                        case (byte)SubCmdType.SetWorkingSensor:                                      // Załaduj sensori o indexie...
                            query[5] = parameters[2];
                            complement = 6;
                            break;
                        case (byte)SubCmdType.SetSensorOdr:                                      // Ustaw ODR wybranego sensora
                            query[5] = parameters[2];
                            query[6] = parameters[3];
                            query[7] = parameters[4];
                            query[8] = parameters[5];
                            complement = 9;
                            break;
                        case (byte)SubCmdType.SetSensorScale:                                      // Ustaw zakres wybranego sensora
                            query[5] = parameters[2];
                            query[6] = parameters[3];
                            query[7] = query[8] = 0x00;
                            complement = 9;
                            break;

                        case (byte)SubCmdType.GetRegisterValue:                                      // Pobierz parametr rejestru
                            query[5] = parameters[2];
                            complement = 6; 
                            break;

                        case (byte)SubCmdType.SetRegisterValue:                                      // Ustaw parametr rejestru
                            query[5] = parameters[2];
                            query[6] = parameters[3];
                            complement = 7;
                            break;
                    }
                    break;

                case (byte)CmdType.SensorEnable:                                              // Włącz przesył danych
                    query[3] = parameters[0];
                    query[4] = parameters[1];
                    query[5] = query[6] = query[7] = query[8] = query[9] = query[10] = 0x00;
                    complement = 11;
                    break;

                case (byte)CmdType.StopTransmition:                                             // Wyłącz przesył danych
                    break;
            }

            // Dodawanie sumy kontrolnej
            query[complement] = CheckSum(query, complement);
            query[complement + 1] = 0xF0;

            // Wstawianie danych do tablicy zwrotnej
            byte[] dataSend = new byte[complement + 2];
            Array.Copy(query, dataSend, complement + 2);

            ComTransmition.SendMessage(dataSend);

            return dataSend;
        }

        private static byte CheckSum(byte[] data, int dlugosc)
        {
            // Obliczanie sumy kontrolnej (przedostatni bajt ramki)
            byte value = 0xFF;
            for (int i = 0; i < dlugosc; i++)
            {
                value -= data[i];
            }

            // Dopełnienie do 0x100
            value += 0x01;

            return value;
        }

        // Funckja zwracająca tablicę z obecnym czasem
        private static byte[] CurrentTime()
        {
            byte[] time = new byte[7];

            DateTime currentTime = DateTime.Now;
            time[0] = (byte)currentTime.Hour;
            time[1] = (byte)currentTime.Minute;
            time[2] = (byte)currentTime.Second;
            time[3] = (byte)currentTime.Millisecond;
            time[4] = (byte)currentTime.Month;
            time[5] = (byte)currentTime.Day;
            time[6] = (byte)currentTime.Year;

            return time;
        }

        public static List<string> GetAvailableSensors(byte sensor)
        {
            List<string> availableSensors = new List<string>();

            //Query(sensor)


            return availableSensors;
        }
    }
}
