using System;

namespace TrePaaRad
{
    class BoardView
    {
        public static void ShowBoard(BoardModel boardModel)
        {

            var board = boardModel.BoxContents;
            Console.WriteLine("  a b c");
            Console.WriteLine(" ┌─────┐");
            Console.WriteLine("1│o    │");
            Console.WriteLine("2│    o│");
            Console.WriteLine("3│× ×  │");
            Console.WriteLine(" └─────┘");
        }
    }
}