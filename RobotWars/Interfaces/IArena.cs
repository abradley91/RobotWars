using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotWars.Interfaces
{
    public interface IArena
    {
        int Width { get; }
        int Height { get; }

        bool IsInsideArenaBounds(int x, int y);
    }
}
