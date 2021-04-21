using System;
using System.Threading;
using System.Windows.Forms;
using Aplikacja_MEMS.Forms;
using Aplikacja_MEMS.Registers;

namespace Aplikacja_MEMS
{
    public abstract class Sensor
    {
        public static byte enableByte = (byte)Sensors.SetSensor.AllEnable;
        public static byte enableInterruptByte = (byte)Sensors.SetSensor.Interupts;
        public byte activate;
        public byte sensorNr;
        public bool isEnabled;
        public string sensorName;
        public SensorRegister register;
        public int selectedDeviceIndex;
        public string type;
        public int width;
        Plot plot;

        // Ustawianie wybranego sensora do pracy
        public void SetSensor(int index)
        {
            Communication.Query((byte)CmdType.SensorCmd, (byte)SubCmdType.SetWorkingSensor, this.sensorNr, (byte)index);
        }

        public void OpenPlot()
        {
            ThreadStart openPlotStart = new ThreadStart(PlotShow);
            Thread openPlot = new Thread(openPlotStart);
            openPlot.Start();
        }

        private void PlotShow()
        {
            Application.Run(plot = new Plot());
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
                Communication.Query((byte)CmdType.SensorCmd, (byte)SubCmdType.SetRegisterValue, this.sensorNr, Analysis.HexUtil.ToBytes(address), Analysis.HexUtil.ToBytes(value));
        }

        public void GetRegisterParameter(string address)
        {
                Communication.Query((byte)CmdType.SensorCmd, (byte)SubCmdType.GetRegisterValue, this.sensorNr, Analysis.HexUtil.ToBytes(address));
        }
     
        public void OpenRegister()
        {
            RegisterList.LSM6DSL();
            if (register == null)
            {
                register = new SensorRegister(RegisterList.r_LSM6DSL);
            }
            register.Visible = true;
            register.TopMost = true;
            register.TopMost = false;
        }

    }
}
