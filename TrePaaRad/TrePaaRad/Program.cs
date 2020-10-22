using System;

namespace TrePaaRad
{
    class Program
    {
        static void Main(string[] args)
        {
            var boardModel = new BoardModel();
            BoardView.ShowBoard(boardModel);

            foreach (var c in boardModel.BoxContents)
            {
                Console.WriteLine(c);
            }
            
        }
    }
}