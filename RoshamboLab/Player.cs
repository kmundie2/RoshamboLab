﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace RoshamboLab
{
    public abstract class Player
    {
        public string Name { get; set; }
        public Roshambo Choice { get; set; }
        public abstract Roshambo GenerateRoshambo();
    }
}
