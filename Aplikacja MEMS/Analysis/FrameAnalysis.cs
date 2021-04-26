using System;

namespace Aplikacja_MEMS.Analysis
{
    class FrameAnalysis
    {
        public static string AddText(byte[] frame, int place, Sensor s, int startIndex)
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
    }
}
