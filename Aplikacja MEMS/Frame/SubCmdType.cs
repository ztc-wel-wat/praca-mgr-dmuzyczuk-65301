namespace Aplikacja_MEMS
{
    enum SubCmdType
    {
        GetRegisterValue = 0x02, SetRegisterValue = 0x03, SetSensorScale = 0x05, SetSensorOdr = 0x07, GetAvaliableSensorList = 0x14, SetWorkingSensor = 0x15
    }
}

// C:\Users\Dawid\Downloads\STM32CubeExpansion_MEMS1_V8.2.0\Drivers\BSP\Components\lsm6dsl