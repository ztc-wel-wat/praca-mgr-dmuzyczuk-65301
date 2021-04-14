using Aplikacja_MEMS.Frame;
using Aplikacja_MEMS.Transmition;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Aplikacja_MEMS
{
    static class Communication
    {
        public static void Query(byte command)
        {
            byte[] query = new byte[5];
            Array.Clear(query, 0, query.Length);

            query[0] = (byte)Identificators.SensorBoardId;
            query[1] = (byte)Identificators.ApplicationId;
            query[2] = command;
            query[3] = CheckSum(query, 3);
            query[4] = (byte)Identificators.FrameEnd;

            ComTransmition.SendMessage(query);
        }

        public static void Query(byte command, string portName)
        {
            byte[] query = new byte[12];
            Array.Clear(query, 0, query.Length);

            query[0] = (byte)Identificators.SensorBoardId;
            query[1] = (byte)Identificators.ApplicationId;
            query[2] = command;
            Array.Copy(CurrentTime(), 0, query, 3, CurrentTime().Length);
            query[10] = CheckSum(query, 10);
            query[11] = (byte)Identificators.FrameEnd;

            ComTransmition.OpenPort(portName);
            ComTransmition.SendMessage(query);
            Thread.Sleep(200);
            ComTransmition.ReadMessage();
        }

        public static byte[] Query(byte command, byte subCommand, byte sensorNr)
        {
            byte[] response;
            byte[] query;

            switch (command)
            {
                case (byte)CmdType.SensorCmd:
                    ComTransmition.ClearBuffer();

                    query = new byte[7];

                    query[0] = (byte)Identificators.SensorBoardId;
                    query[1] = (byte)Identificators.ApplicationId;
                    query[2] = command;
                    query[3] = subCommand;
                    query[4] = sensorNr;
                    query[5] = CheckSum(query, 5);
                    query[6] = (byte)Identificators.FrameEnd;
                    ComTransmition.SendMessage(query);

                    Thread.Sleep(50);
                    response = ComTransmition.ReadMessage();
                    break;

                case (byte)CmdType.SensorEnable:
                    query = new byte[13];

                    query[0] = (byte)Identificators.SensorBoardId;
                    query[1] = (byte)Identificators.ApplicationId;
                    query[2] = command;
                    query[3] = subCommand;
                    query[4] = sensorNr;
                    query[5] = query[6] = query[7] = query[8] = query[9] = query[10] = 0x0;
                    query[11] = CheckSum(query, 5);
                    query[12] = (byte)Identificators.FrameEnd;
                    ComTransmition.SendMessage(query);

                    response = null;
                    break;
                default:
                    response = null;
                    break;
            }

            return response;
        }

        public static void Query(byte command, byte subCommand, byte sensorNr, byte parameter)
        {
            byte[] query = new byte[8];

            query[0] = (byte)Identificators.SensorBoardId;
            query[1] = (byte)Identificators.ApplicationId;
            query[2] = command;
            query[3] = subCommand;
            query[4] = sensorNr;
            query[5] = parameter;
            query[6] = CheckSum(query, 6);
            query[7] = (byte)Identificators.FrameEnd;

            ComTransmition.SendMessage(query);
        }

        public static void Query(byte command, byte subCommand, byte sensorNr, byte[] parameter)
        {
            byte[] query = new byte[11];

            query[0] = (byte)Identificators.SensorBoardId;
            query[1] = (byte)Identificators.ApplicationId;
            query[2] = command;
            query[3] = subCommand;
            query[4] = sensorNr;
            query[5] = parameter[0];
            query[6] = parameter[1];
            query[7] = parameter[2];
            query[8] = parameter[3];
            query[9] = CheckSum(query, 9);
            query[10] = (byte)Identificators.FrameEnd;

            ComTransmition.SendMessage(query);
        }
        public static void Query(byte command, byte subCommand, byte sensorNr, byte parameterAddress, byte parameterValue)
        {
            byte[] query = new byte[9];

            query[0] = (byte)Identificators.SensorBoardId;
            query[1] = (byte)Identificators.ApplicationId;
            query[2] = command;
            query[3] = subCommand;
            query[4] = sensorNr;
            query[5] = parameterAddress;
            query[6] = parameterValue;
            query[7] = CheckSum(query, 7);
            query[8] = (byte)Identificators.FrameEnd;

            ComTransmition.SendMessage(query);
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

        // Pobieranie listy dostępnych czujników
        public static List<string> GetAvailableSensors(byte sensor)
        {
            List<string> availableSensors = new List<string>();

            // Wysłanie zapytania o dostępne urządzenia
            byte[] response = Query((byte)CmdType.SensorCmd, (byte)SubCmdType.GetAvaliableSensorList, sensor);

            // W przypadku braku odpowiedzi - brak urzadzen
            if (response != null)
            {
                // Dekodowanie odpowiedz
                string frame = Encoding.UTF8.GetString(response, 5, response.Length - 7);

                // Wyodrębnianie nazw urządzeń spomiędzy przecinków i dodawanie do listy
                while (frame.IndexOf(',') != -1)
                {
                    string buffer = frame.Substring(0, frame.IndexOf(','));
                    frame = frame.Remove(0, frame.IndexOf(',') + 1);
                    availableSensors.Add(buffer);
                }
                availableSensors.Add(frame);

                return availableSensors;
            }
            else return null;
        }
    }
}
