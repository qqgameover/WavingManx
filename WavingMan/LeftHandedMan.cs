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
            Console.WriteLine(_shouldWaveNextTime ? "\\o " : " o");
            SetCursorLeft();
            Console.WriteLine(_shouldWaveNextTime ? " |\\" : " |");
            SetCursorLeft();
            Console.Write("/ \\");
            _shouldWaveNextTime = !_shouldWaveNextTime;
        }
    }
}
