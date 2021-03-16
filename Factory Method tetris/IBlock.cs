namespace Factory_Method_tetris
{
    class IBlock : TetrisFigure
    {
        public int[,] figure = new int[4, 4] { { 1, 1, 1, 1 },
                                              { 0, 0, 0, 0 },
                                              { 0, 0, 0, 0 },
                                              { 0, 0, 0, 0 } };

        public override Color Color => Color.Red;

        public override int[,] Figure()
        {
            return figure;
        }

        public override string FigureName()
        {
            return "IBlock";
        }
    }
}
