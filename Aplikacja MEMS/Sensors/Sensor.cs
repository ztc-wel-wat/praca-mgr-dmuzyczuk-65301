using System.Threading;
using System.Windows.Forms;
using Aplikacja_MEMS.Forms;

namespace Aplikacja_MEMS
{
    public abstract class Sensor
    {
        public static float odrSum = 0;
        public float odr;
        public static byte enableByte = (byte)Sensors.SetSensor.AllEnable;
        public static byte enableInterruptByte = (byte)Sensors.SetSensor.Interupts;
        public byte activate;
        public byte sensorNr;
        public bool isEnabled;
        public string sensorName;
        public int selectedDeviceIndex;
        public string type;
        public int width;
        protected Plot plot;
        protected SensorRegister register;

        public abstract void AddData(object data);
        public abstract void ClearData();
        public abstract string GetData();

        // Ustawianie wybranego sensora do pracy
        public void SetSensor(int index)
        {
            Communication.Query((byte)CmdType.SensorCmd, (byte)SubCmdType.SetWorkingSensor, this.sensorNr, (byte)index);
        }

        public bool SumOdr(object sender, float newOdr)
        {
            if (sender is CheckBox)
            {
                if (isEnabled)
                {
                    odrSum += newOdr;
                    odr = newOdr;
                }
                else
                    odrSum -= odr;
            }
            else if (sender is ComboBox)
                if (isEnabled)
                {
                    odrSum = odrSum - odr + newOdr;
                    odr = newOdr;
                }

            return (odrSum < 100);
        }

        public void OpenPlot(int scale)
        {
            if (plot == null)
            {
                ParameterizedThreadStart openPlotStart = new ParameterizedThreadStart(PlotShow);
                Thread openPlot = new Thread(openPlotStart);
                openPlot.Priority = ThreadPriority.AboveNormal;
                openPlot.Start((object)scale);
            }
            else
                plot.ShowMe();
        }

        private void PlotShow(object scale)
        {
            Application.Run(plot = new Plot(this.sensorName, (int)scale));
        }

        public void ClearPlot()
        {
            plot.ClearPlot();
        }

        public void ClosePlot()
        {
            plot.ExitPlot();
        }

        public void SetPlotScale(int scale)
        {
            plot.SetScale(scale);
        }

        public static void EnableAll()
        {
            enableByte = (byte)Sensors.SetSensor.AllEnable;
            enableInterruptByte = (byte)Sensors.SetSensor.AllDisable;
            Communication.Query((byte)CmdType.SensorEnable, enableByte, enableInterruptByte);
        }
        public static void DisableAll()
        {
            enableByte = (byte)Sensors.SetSensor.AllDisable;
            enableInterruptByte = (byte)Sensors.SetSensor.AllDisable;
            Communication.Query((byte)CmdType.SensorEnable, enableByte, enableInterruptByte);
        }

        public static void ChangeInterrupt()
        {
            if (enableInterruptByte == (byte)Sensors.SetSensor.Interupts) enableInterruptByte = (byte)Sensors.SetSensor.AllDisable;
            else enableInterruptByte = (byte)Sensors.SetSensor.Interupts;
            Communication.Query((byte)CmdType.SensorEnable, enableByte, enableInterruptByte);
        }

        // Włączanie/wyłączanie sensora
        public void SetEnable(bool enabled)
        {
            if (enabled) enableByte += this.activate;
            else enableByte -= this.activate;

            this.isEnabled = enabled;

            Communication.Query((byte)CmdType.SensorEnable, enableByte, enableInterruptByte);
        }

        // Ustawianie ODR
        public void SetOdr(byte[] parameter)
        {
            Communication.Query((byte)CmdType.SensorCmd, (byte)SubCmdType.SetSensorOdr, this.sensorNr, parameter);
        }

        // Ustawianie parametru
        public void SetRegisterParameter(string address, string value)
        {
            try
            {
                Communication.Query((byte)CmdType.SensorCmd, (byte)SubCmdType.SetRegisterValue, this.sensorNr, Analysis.HexUtil.ToBytes(address), Analysis.HexUtil.ToBytes(value));
            }
            catch { }
        }

        public void GetRegisterParameter(string address)
        {
            try
            {
                Communication.Query((byte)CmdType.SensorCmd, (byte)SubCmdType.GetRegisterValue, this.sensorNr, Analysis.HexUtil.ToBytes(address));
            }
            catch { }
        }

        public void AssignRegister(SensorRegister sensorRegister)
        {
            register = sensorRegister;
        }


        public void AddToRegisters(string address, string parameter)
        {
            register.AddData(address, parameter);
        }

    }
}
