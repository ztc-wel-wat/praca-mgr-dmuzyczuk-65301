using System;

namespace Aplikacja_MEMS
{
    public abstract class Sensor
    {
        public static byte enableByte = 0x77;
        public static byte enableInterruptByte = 0x01;
        public byte activate;
        public byte sensorNr;
        public bool isEnabled;
        public string sensorName;
        public SensorRegister register;
        public int selectedDeviceIndex;

        public void OpenRegister(string name)
        {
            if (register.Visible == false)
            {
                register = new SensorRegister();
                register.Text = "Rejestr " + name;
                register.Visible = true;
            }
            else
            {
                register.TopMost = true;
                register.TopMost = false;
            }
        }

        // Ustawianie wybranego sensora do pracy
        public void SetSensor(int index)
        {
            Communication.Query((byte)CmdType.SensorCmd, (byte)SubCmdType.SetWorkingSensor, this.sensorNr, (byte)index);
        }

        public static void EnableAll()
        {
            enableByte = 0x77;
            enableInterruptByte = 0x01;
            Communication.Query((byte)CmdType.SensorEnable, enableByte, enableInterruptByte);
        }
        public static void DisableAll()
        {
            enableByte = 0x00;
            enableInterruptByte = 0x00;
            Communication.Query((byte)CmdType.SensorEnable, enableByte, enableInterruptByte);
        }

        public static void ChangeInterrupt()
        {
            if (enableInterruptByte == 0x01) enableInterruptByte = 0x00;
            else enableInterruptByte = 0x01;
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
                Communication.Query((byte)CmdType.SensorCmd, (byte)SubCmdType.SetRegisterValue, this.sensorNr, (byte)(Int32.Parse(address)), (byte)(Int32.Parse(value)));
            }
            catch (Exception exc) { };
        }

        public void GetRegisterParameter(string address)
        {
            try
            {
                Communication.Query((byte)CmdType.SensorCmd, (byte)SubCmdType.GetRegisterValue, this.sensorNr, (byte)Int32.Parse(address));
            }
            catch (Exception exc) { };
        }

    }
}
