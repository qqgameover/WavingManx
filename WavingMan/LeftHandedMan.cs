using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WavingMan
{
    class LeftHandedMan : Man
    {
        public LeftHandedMan(int x, int y, int dx, int dy) : base(x, y, dx, dy)
        {
        }

        public override void Show()
        {
            SetCursorTop();
            SetCursorLeft();
            Console.WriteLine(ShouldWaveNextTime ? " o/" : " o");
             SetCursorLeft();
            Console.WriteLine(ShouldWaveNextTime ?  "/| "  : " |");
            SetCursorLeft();
            Console.Write("/ \\");
            ShouldWaveNextTime = !ShouldWaveNextTime;
        }
    }
}
