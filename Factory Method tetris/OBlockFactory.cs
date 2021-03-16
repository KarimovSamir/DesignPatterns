namespace Factory_Method_tetris
{
    class OBlockFactory : TetrisFigureFactory
    {
        public override TetrisFigure CreateFigure()
        {
            return new OBlock();
        }
    }
}
