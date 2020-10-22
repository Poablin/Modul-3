using System;
using System.Security.Cryptography.X509Certificates;
using Console = System.Console;

namespace TrePaaRad
{
    class BoardView
    {
        public static void ShowBoard(BoardModel boardModel)
        {

            var board = boardModel.BoxContents;
            Console.WriteLine("   a b c");
            Console.WriteLine(" ┌───────┐");
            var startIndex = 0;
            ShowOneLine(0, board);
            ShowOneLine(3, board);
            ShowOneLine(6, board);
            Console.WriteLine(" └───────┘");
        }
        public static void ShowOneLine(int startIndex, CellContent[] board)
        {
            var lineNo = 1 + startIndex / 3;
            Console.Write(lineNo +  "│");
            for (var i = startIndex; i < startIndex + 3; i++)
            {
                if (i > startIndex) Console.Write(' ');
                var isBlank = board[i] == CellContent.None;
                var isCross = board[i] == CellContent.Cross;
                Console.Write(isBlank ? ' ' : isCross ? 'x' : 'o');
            }
            Console.WriteLine("│");
        }
    }
}