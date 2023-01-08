// Copyright (c) 2023 KOMATA Manabu
// SPDX-License-Identifier: MIT
using System.Threading;
using System.Device.Gpio;

namespace Blinky
{
    public class Program
    {
        private static GpioController s_GpioController;

        public static void Main()
        {
            s_GpioController = new GpioController();

            // ESP32C3
            GpioPin led = s_GpioController.OpenPin(10, PinMode.Output);

            led.Write(PinValue.Low);

            while (true)
            {
                led.Toggle();
                Thread.Sleep(1000);
                led.Toggle();
                Thread.Sleep(1000);
            }
        }
    }
}
