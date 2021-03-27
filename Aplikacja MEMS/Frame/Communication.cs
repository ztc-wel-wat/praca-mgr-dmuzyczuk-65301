using Aplikacja_MEMS.Frame;
using Aplikacja_MEMS.Transmition;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

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

            switch (command)
            {
                case (byte)CmdType.StopTransmition:
                    Thread.Sleep(200);
                    ComTransmition.ReadMessage();
                    ComTransmition.ClosePort();
                    break;
            }
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

            byte[] query = new byte[7];
            Array.Clear(query, 0, query.Length);

            query[0] = (byte)Identificators.SensorBoardId;
            query[1] = (byte)Identificators.ApplicationId;
            query[2] = command;
            query[3] = subCommand;
            query[4] = sensorNr;
            query[5] = CheckSum(query, 5);
            query[6] = (byte)Identificators.FrameEnd;

            ComTransmition.SendMessage(query);
            Thread.Sleep(200);
            response = ComTransmition.ReadMessage();

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
            Thread.Sleep(200);
            ComTransmition.ReadMessage();
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

            byte[] response = Query((byte)CmdType.SensorCmd, (byte)SubCmdType.GetAvaliableSensorList, sensor);

            if (response != null)
            {
                string frame = Encoding.UTF8.GetString(response, 5, response.Length - 7);

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
