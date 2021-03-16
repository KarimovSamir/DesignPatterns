namespace Factory_Method_tetris
{
    class JBlock : TetrisFigure
    {
        public int[,] figure = new int[4, 4] { { 1, 0, 0, 0 },
                                              { 1, 1, 1, 0 },
                                              { 0, 0, 0, 0 },
                                              { 0, 0, 0, 0 } };

        public override Color Color => Color.Blue;

        public override int[,] Figure()
        {
            return figure;
        }

        public override string FigureName()
        {
            return "JBlock";
        }
    }
}
