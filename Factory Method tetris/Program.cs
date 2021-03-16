using System;
using System.Collections.Generic;

namespace Factory_Method_tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfTetrisFigure = new List<TetrisFigure>();
            for (int i = 0; i < 10; i++)
            {
                listOfTetrisFigure.Add(RandomFigure());
            }
            foreach (var item in listOfTetrisFigure)
            {
                item.ShowInfo();
            }
        }
        public static TetrisFigure RandomFigure()
        {
            Random random = new Random();
            var listOfTetrisFigure = new List<TetrisFigureFactory>();
            listOfTetrisFigure.Add(new OBlockFactory());
            listOfTetrisFigure.Add(new JBlockFactory());
            listOfTetrisFigure.Add(new IBlockFactory());

            var randomTetrisFigureIndex = random.Next(0, listOfTetrisFigure.Count);
            return listOfTetrisFigure[randomTetrisFigureIndex].CreateFigure();
        }
    }
}
