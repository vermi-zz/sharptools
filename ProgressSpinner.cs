using System;

namespace su.oishiide.tools
{
    public class ProgressSpinner
    {
        int counter;
        public ProgressSpinner()
        {
            counter = 0;
        }
        public void Tick()
        {
            counter++;
            switch (counter % 4)
            {
                case 0: Console.Write("/"); break;
                case 1: Console.Write("-"); break;
                case 2: Console.Write("\\"); break;
                case 3: Console.Write("-"); break;
            }
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
        }
        public void Tick(int x, int y)
        {
            counter++;
            switch (counter % 4)
            {
                case 0: Console.Write("/"); break;
                case 1: Console.Write("-"); break;
                case 2: Console.Write("\\"); break;
                case 3: Console.Write("-"); break;
            }
            Console.SetCursorPosition(x, y);
        }
    }
}

