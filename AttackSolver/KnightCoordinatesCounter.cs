using AttackSolver.Interfaces;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace AttackSolver
{
    public class KnightCoordinatesCounter : IMovePiece
    {
        public int GetAvaliableCoordinatesCount(Size boardSize, Point startCoords, Point[] obstacles)
        {
            var coordinates = new List<Point>();

            //Move up and right
            int x = startCoords.X + 1;
            int y = startCoords.Y + 2;

            if (boardSize.Width >= x || boardSize.Height >= y)
                coordinates.Add(new Point(x, y));

            if (obstacles.Contains(coordinates[coordinates.Count - 1]))
                coordinates.Remove(coordinates[coordinates.Count - 1]);

            x = startCoords.X + 2;
            y = startCoords.Y + 1;

            if (boardSize.Width >= x && boardSize.Height >= y)
                coordinates.Add(new Point(x, y));

            if (obstacles.Contains(coordinates[coordinates.Count - 1]))
                coordinates.Remove(coordinates[coordinates.Count - 1]);

            //Move down and right
            x = startCoords.X + 1;
            y = startCoords.Y - 2;

            if (boardSize.Width >= x && y > 0)
                coordinates.Add(new Point(x, y));

            if (obstacles.Contains(coordinates[coordinates.Count - 1]))
                coordinates.Remove(coordinates[coordinates.Count - 1]);

            x = startCoords.X + 2;
            y = startCoords.Y - 1;
            if (boardSize.Width >= x && y > 0)
                coordinates.Add(new Point(x, y));

            if (obstacles.Contains(coordinates[coordinates.Count - 1]))
                coordinates.Remove(coordinates[coordinates.Count - 1]);

            //Move down and left
            x = startCoords.X - 1;
            y = startCoords.Y - 2;

            if (x > 0 && y > 0)
                coordinates.Add(new Point(x, y));

            if (obstacles.Contains(coordinates[coordinates.Count - 1]))
                coordinates.Remove(coordinates[coordinates.Count - 1]);

            x = startCoords.X - 2;
            y = startCoords.Y - 1;

            if (x > 0 && y > 0)
                coordinates.Add(new Point(x, y));

            if (obstacles.Contains(coordinates[coordinates.Count - 1]))
                coordinates.Remove(coordinates[coordinates.Count - 1]);

            //Move up and left
            x = startCoords.X - 2;
            y = startCoords.Y + 1;

            if (x > 0 && boardSize.Height >= y)
                coordinates.Add(new Point(x, y));

            if (obstacles.Contains(coordinates[coordinates.Count - 1]))
                coordinates.Remove(coordinates[coordinates.Count - 1]);

            x = startCoords.X - 1;
            y = startCoords.Y + 2;

            if (x > 0 && boardSize.Height >= y)
                coordinates.Add(new Point(x, y));

            if (obstacles.Contains(coordinates[coordinates.Count - 1]))
                coordinates.Remove(coordinates[coordinates.Count - 1]);

            return coordinates.Count;
        }
    }
}
