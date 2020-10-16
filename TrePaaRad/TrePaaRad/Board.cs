namespace TrePaaRad
{
    class Board
    {
        public bool IsGameStopped { get; private set; }
        public CellContent[] BoxContents { get; private set; }

        public Board()
        {
            BoxContents = new CellContent[9];
        }
    }
}