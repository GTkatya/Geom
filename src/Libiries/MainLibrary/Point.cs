using static System.Console;

namespace Geom.MainLibrary
{
    public struct Point
    {
        const char symbol = '*';
        public int X, Y;
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public void Draw()
        {
            SetCursorPosition(X, Y);
            Write(symbol);
        }
    }
}
