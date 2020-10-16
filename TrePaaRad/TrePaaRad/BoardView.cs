using System;

namespace TrePaaRad
{
    class BoardView
    {
        public static void ShowBoard()
        {
            string board = "   a b c\r\n ┌─────┐\r\n1│o    │\r\n2│    o│\r\n3│× ×  │\r\n └─────┘";
            Console.WriteLine(board);
        }
    }
}