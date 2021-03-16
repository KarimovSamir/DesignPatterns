namespace Factory_Method_tetris
{
    class OBlock : TetrisFigure
    {
        public int[,] figure = new int[4, 4] { { 1, 1, 0, 0 },
                                              { 1, 1, 0, 0 },
                                              { 0, 0, 0, 0 },
                                              { 0, 0, 0, 0 } };

        public override Color Color => Color.Green;

        public override int[,] Figure()
        {
            return figure;
        }

        public override string FigureName()
        {
            return "OBlock";
        }
    }
}
