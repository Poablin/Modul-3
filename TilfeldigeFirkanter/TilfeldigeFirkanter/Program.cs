using System;

namespace TilfeldigeFirkanter
{
    class Program
    {
        static void Main(string[] args)
        {
            var row1 = new VirtualScreenRow(20);
            //var row2 = new VirtualScreenRow(20);
            //var row3 = new VirtualScreenRow(20);
            //row2.AddBoxMiddleRow(4, 5);
            row1.AddBoxTopRow(5, 3);
            //row3.AddBoxBottomRow(3, 7);
            row1.Show();
            //row2.Show();
            //row3.Show();
        }
    }
}
