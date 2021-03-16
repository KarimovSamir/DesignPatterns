using System;

namespace Factory_Method_tetris
{
    abstract class TetrisFigure
    {
        public abstract int[,] Figure();
        public abstract string FigureName();
        public abstract Color Color { get; }

        public void ShowInfo()
        {
            Console.WriteLine(
                $"Название фигуры: {FigureName()}\n" +
                $"Цвет: {Color}\n" +
                $"Фигура:\n"
            );
            int[,] a = Figure();
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write("{0,3}", a[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
