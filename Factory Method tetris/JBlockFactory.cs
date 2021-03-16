namespace Factory_Method_tetris
{
    class JBlockFactory : TetrisFigureFactory
    {
        public override TetrisFigure CreateFigure()
        {
            return new JBlock();
        }
    }
}
