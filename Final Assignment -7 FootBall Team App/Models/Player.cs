using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace day9.Foot_Ball_Team_App.Models
{
    internal class Player
    {
        public int PID { get; set; }
        public string Pname { get; set; }
        public int Age { get; set; }

        public Player(int i, string j, int k)
        {
            PID = i;
            Pname = j;
            Age = k;
        }
    }
}
