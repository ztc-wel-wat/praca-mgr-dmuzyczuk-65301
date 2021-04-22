using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace Aplikacja_MEMS.Analysis
{
    class FrameAnalysis
    {
        private static bool enabled = false;

        public static void Enable()
        {
            enabled = true;
        }
        public static void Analysis(Queue<byte> data, Queue<byte[]> frames)
        {
            enabled = true;
            while (enabled)
            {
                while (data != null)
                {
                    byte[] buffer = new byte[16384];
                    int count = 0;

                    // Oczekiwanie na wypadek pustej kolejki
                    while (data.Count == 0)
                        if (!enabled)
                            return;

                    byte add = data.Dequeue();

                    // Dodawanie kolejnych bajtów do buffora
                    while (add != (byte)Frame.Identificators.FrameEnd)
                    {
                        buffer[count] = add;
                        count++;

                        while (data.Count == 0)
                            if (!enabled)
                                return;

                        add = data.Dequeue();
                    }

                    // Dodanie ramki do kolejki
                    byte[] frame = new byte[count];
                    Array.Copy(buffer, frame, frame.Length);

                    frames.Enqueue(frame);
                }
            }
        }

        public static void CheckSum(Queue<byte[]> source, Queue<byte[]> destination)
        {
            enabled = true;
            while (enabled)
            {
                while (source.Count == 0)
                    if (!enabled)
                        return;

                byte sum = 0x00;
                byte[] toCheck = source.Dequeue();

                if (toCheck != null)
                {
                    foreach (byte b in toCheck)
                        sum += b;

                    if (sum == 0x00)
                    {
                        destination.Enqueue(toCheck);
                    }
                }
            }
        }

        public static void SensorData(Queue<byte[]> data, List<Sensor> sensors, RichTextBox rtBox, bool show)
        {
            enabled = true;
            while (enabled)
            {
                if (data.Count > 0)
                {

                    byte[] frame = data.Dequeue();
                    if (frame != null)
                    {
                        int sensorIndex = 0;
                        int startIndex = 9;

                        int floated = (System.BitConverter.ToInt32(frame, 3)) * 10;
                        DateTime timestamp = new DateTime(floated);

                        string showText = timestamp.ToString("H:mm:ss.ffffff") + " |";

                        foreach (Sensor s in sensors)
                        {
                            showText += AddText(frame, sensorIndex, s, startIndex);
                            sensorIndex++;
                        }

                        if ((frame[7] & (1 << 6)) != 0)
                        {
                            showText += "   0x" + frame[9].ToString("X2") + "   |";
                            startIndex += 4;
                        }
                        else showText += "          |";

                        if (UserForm.showText)
                        {
                            rtBox.Invoke((Action)delegate
                            {
                                rtBox.Text += (showText + "0x" + frame[7].ToString("X2") + "\n");
                            });

                        }
                           
                    }
                }
            }


        }
        public static void AssignFrames(Queue<byte[]> checkedFrames, Data<byte[]> command, Queue<byte[]> sensorsData)
        {
            enabled = true;
            while (enabled)
            {
                if (checkedFrames.Count > 0)
                {
                    byte[] fr;

                    // Sprawdzanie czy kolejka nie jest pusta
                    while (checkedFrames.Count == 0)
                        if (!enabled)
                            return;

                    // Pobieranie tablicy z kolejki
                    fr = checkedFrames.Dequeue();

                    // na wypadek pobrania "pustej" tablicy
                    if (fr != null && fr.Length > 4)
                    {
                        if (fr[2] == (byte)CmdType.SensorResp && fr[3] == (byte)SubCmdType.GetRegisterValue)
                        {
                            command.Enqueue(fr);
                        }
                        else if (fr[2] == (byte)CmdType.ResponseData)
                        {
                            sensorsData.Enqueue(fr);
                        }
                    }

                }

            }
        }
        private static string AddText(byte[] frame, int place, Sensor s, int startIndex)
        {
            string text = "";
            if (s.type == "Env")
            {
                if ((frame[7] & (1 << place)) != 0)
                {
                    float toAdd = (System.BitConverter.ToSingle(frame, startIndex));
                    string floated = toAdd.ToString("0.00");

                    floated += "|";
                    floated = String.Format("{0," + s.width + "}", floated);
                    text += floated;
                    startIndex += 4;

                    s.AddData(toAdd);
                }
                else
                {
                    for (int j = 0; j < s.width - 1; j++)
                    {
                        text += " ";
                    }
                    text += "|";
                }
            }
            else if (s.type == "Motion")
            {
                if ((frame[7] & (1 << place)) != 0)
                {
                    int[] data = new int[3];
                    for (int i = 0; i < 3; i++)
                    {
                        int inted = (System.BitConverter.ToInt32(frame, startIndex));
                        data[i] = inted;


                        string floated = inted.ToString() + "|";
                        floated = String.Format("{0," + s.width + "}", floated);
                        text += floated;
                        startIndex += 4;
                    }
                    s.AddData(data);
                }
                else
                {
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < s.width - 1; j++)
                        {
                            text += " ";
                        }
                        text += "|";
                    }
                }
            }

            return text;
        }

        public static void Disable()
        {
            enabled = false;
        }
    }
}
