﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Tesla : ICar, IElectricCar
    {
        public string Model { get; set; }
        public string Color { get; set; }

        public int Battery { get; set; }
        public Tesla(string model, string color, int battery)
        {
            this.Model = model;
            this.Color = color;
            this.Battery = battery;
        }
        string Start()
        {
            return "Engine start";
        }

        string Stop()
        {
            return "Breaaak!";
        }
        public override string ToString()
        {
            return $"{Color} Seat {Model} with {Battery} Batteries";
        }

    }
}
