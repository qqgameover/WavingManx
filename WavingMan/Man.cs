﻿using System;

namespace WavingMan
{
    public class Man
    {
        public Position Position { get; }
        public Position Speed { get; }
        internal bool ShouldWaveNextTime = false;

        public Man(int x, int y, int dx, int dy)
        {

            Position = new Position(x, y);
            Speed = new Position(dx, dy);
        }

        public virtual void Show()
        {
            SetCursorTop();
            SetCursorLeft();
            Console.WriteLine(ShouldWaveNextTime ? " o/" : " o");
            SetCursorLeft();
            Console.WriteLine(ShouldWaveNextTime ?  "/|" : " |");
            SetCursorLeft();
            Console.Write("/ \\");
            ShouldWaveNextTime = !ShouldWaveNextTime;
        }

        internal void SetCursorTop()
        {
            Console.CursorTop = Math.Max(Position.Y, 0);
        }

        internal void SetCursorLeft()
        {
            Console.CursorLeft = Math.Max(Position.X - 1, 0);
        }

        public void Move()
        {
            var windowWidth = Console.WindowWidth;
            var windowHeight = Console.WindowHeight;

            if (Position.X <= 1) Speed.X = 1;
            if (Position.X >= windowWidth - 1) Speed.X = -1;
            if (Position.Y <= 1) Speed.Y = 1;
            if (Position.Y >= windowHeight - 1) Speed.Y = -1;

            Position.Move(Speed);
        }
    }
}
