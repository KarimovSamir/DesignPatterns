namespace Factory_Method_tetris
{
    class IBlockFactory : TetrisFigureFactory
    {
        public override TetrisFigure CreateFigure()
        {
            return new IBlock();
        }
    }
}
