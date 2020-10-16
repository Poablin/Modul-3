namespace TrePaaRad
{
    class BoardModel
    {
        public bool IsGameStopped { get; private set; }
        public CellContent[] BoxContents { get; private set; }

        public BoardModel()
        {
            BoxContents = new CellContent[9];
        }
    }
}