using AttackSolver.Interfaces;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace AttackSolver
{
    public class KnightCoordinatesCounter : IKnightCoordinatesCounter
    {
        public int GetNumberOfCoordinates(Size boardSize, Point startCoords, Point[] obstacles)
        {
            var coordinates = new List<Point>();

            //Move up and right
            int x = startCoords.X + 1;
            int y = startCoords.Y + 2;

            if (boardSize.Width >= x || boardSize.Height >= y)
                coordinates.Add(new Point(x, y));

            if (obstacles.Contains(coordinates.Last()))
                coordinates.Remove(coordinates.Last());

            x = startCoords.X + 2;
            y = startCoords.Y + 1;

            if (boardSize.Width >= x || boardSize.Height >= y)
                coordinates.Add(new Point(x, y));

            if (obstacles.Contains(coordinates.Last()))
                coordinates.Remove(coordinates.Last());

            //Move down and right
            x = startCoords.X + 1;
            y = startCoords.Y - 2;

            if (boardSize.Width >= x || boardSize.Height >= 1)
                coordinates.Add(new Point(x, y));

            if (obstacles.Contains(coordinates.Last()))
                coordinates.Remove(coordinates.Last());

            x = startCoords.X + 2;
            y = startCoords.Y - 1;
            if (boardSize.Width >= x || boardSize.Height >= 1)
                coordinates.Add(new Point(x, y));

            if (obstacles.Contains(coordinates.Last()))
                coordinates.Remove(coordinates.Last());

            //Move down and left
            x = startCoords.X - 1;
            y = startCoords.Y - 2;

            if (boardSize.Width >= 1 || boardSize.Height >= 1)
                coordinates.Add(new Point(x, y));

            if (obstacles.Contains(coordinates.Last()))
                coordinates.Remove(coordinates.Last());

            x = startCoords.X - 2;
            y = startCoords.Y - 1;

            if (boardSize.Width >= 1 || boardSize.Height >= 1)
                coordinates.Add(new Point(x, y));

            if (obstacles.Contains(coordinates.Last()))
                coordinates.Remove(coordinates.Last());

            //Move up and left
            x = startCoords.X - 2;
            y = startCoords.Y + 1;

            if (boardSize.Width >= 1 || boardSize.Height >= y)
                coordinates.Add(new Point(x, y));

            if (obstacles.Contains(coordinates.Last()))
                coordinates.Remove(coordinates.Last());

            x = startCoords.X - 1;
            y = startCoords.Y + 2;

            if (boardSize.Width >= 1 || boardSize.Height >= y)
                coordinates.Add(new Point(x, y));

            if (obstacles.Contains(coordinates.Last()))
                coordinates.Remove(coordinates.Last());

            return coordinates.Count;
        }
    }
}
