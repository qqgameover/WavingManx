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

        protected override void WriteBody()
        {
            Console.WriteLine(ShouldWaveNextTime ? "/| " : " |");
        }

        protected override void WriteHead()
        {
            Console.WriteLine(ShouldWaveNextTime ? " o/" : " o");
        }
    }
}
