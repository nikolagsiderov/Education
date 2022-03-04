using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeGame
{
    class Snake
    {
        public Snake()
        {
            this.BodyCoordinatesX = new Queue<int>();
            this.BodyCoordinatesY = new Queue<int>();
        }

        public Queue<int> BodyCoordinatesX { get; set; }

        public Queue<int> BodyCoordinatesY { get; set; }

        public int Count => BodyCoordinatesX.Count;

        public char Symbol { get; set; }
    }
}
