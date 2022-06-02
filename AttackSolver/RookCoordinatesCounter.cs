using AttackSolver.Interfaces;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace AttackSolver
{
    public class RookCoordinatesCounter : IMovePiece
    {

        public int GetAvaliableCoordinatesCount(Size boardSize, Point startCoords, Point[] obstacles)
        {    
            var coordinates = new List<Point>();

            //Move up
            for (int y = startCoords.Y + 1; y <= boardSize.Height; y++)
            {
                coordinates.Add(new Point(startCoords.X, y));

                if (obstacles.Contains(coordinates[coordinates.Count - 1]))
                {
                    coordinates.Remove(coordinates[coordinates.Count - 1]);
                    break;
                }
            };

            //Move down
            for (int y = startCoords.Y - 1; y >= 1; y--)
            {
                coordinates.Add(new Point(startCoords.X, y));

                if (obstacles.Contains(coordinates[coordinates.Count - 1]))
                {
                    coordinates.Remove(coordinates[coordinates.Count - 1]);
                    break;
                }
            };

            //Move right
            for (int x = startCoords.X + 1; x <= boardSize.Width; x++)
            {
                coordinates.Add(new Point(x, startCoords.Y));

                if (obstacles.Contains(coordinates[coordinates.Count - 1]))
                {
                    coordinates.Remove(coordinates[coordinates.Count - 1]);
                    break;
                }

            };

            //Move left
            for (int x = startCoords.X - 1; x >= 1; x--)
            {
                coordinates.Add(new Point(x, startCoords.Y));

                if (obstacles.Contains(coordinates[coordinates.Count - 1]))
                {
                    coordinates.Remove(coordinates[coordinates.Count - 1]);
                    break;
                }
            };

            return coordinates.Count;
        }
    }
}

