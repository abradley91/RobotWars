using RobotWars.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotWars
{
    public class Arena : IArena
    {
        public Arena(int x, int y)
        {
            if(x <= 0 || y <= 0)
            {
                throw new Exception("Arena inputs are invalid.");
            }

            Width = x;
            Height = y;
        }

        public int Width { get; }
        public int Height { get; }

        public bool IsInsideArenaBounds(int x, int y)
        {
            bool greaterThanMin = x >= 0 && y >= 0;
            bool lessThanMax = x <= Width && y <= Height;

            return greaterThanMin && lessThanMax;
        }
    }
}
