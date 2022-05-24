using AttackSolver.Interfaces;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace AttackSolver
{
    public class BishopCoordinatesCounter : IBishopCoordinatesCounter
    {
        public int GetNumberOfCoordinates(Size boardSize, Point startCoords, Point[] obstacles)
        {
            var coordinates = new List<Point>();

            //Move up and right
            for (int x = startCoords.X + 1, y = startCoords.Y + 1; x < boardSize.Width && y < boardSize.Height; x++, y++)
            {
                coordinates.Add(new Point(x, y));

                if (obstacles.Contains(coordinates.Last()))
                {
                    coordinates.Remove(coordinates.Last());
                    break;
                }
            }

            //Move down and right
            for (int x = startCoords.X + 1, y = startCoords.Y - 1; x < boardSize.Width && y >= 1; x++, y--)
            {
                coordinates.Add(new Point(x, y));

                if (obstacles.Contains(coordinates.Last()))
                {
                    coordinates.Remove(coordinates.Last());
                    break;
                }
            }

            //Move down and left
            for (int x = startCoords.X - 1, y = startCoords.Y - 1; x >= 1 && y >= 1; x--, y--)
            {
                coordinates.Add(new Point(x, y));

                if (obstacles.Contains(coordinates.Last()))
                {
                    coordinates.Remove(coordinates.Last());
                    break;
                }
            }

            //Move up and left
            for (int x = startCoords.X - 1, y = startCoords.Y + 1; x >= 1 && y < boardSize.Height; x--, y++)
            {
                coordinates.Add(new Point(x, y));

                if (obstacles.Contains(coordinates.Last()))
                {
                    coordinates.Remove(coordinates.Last());
                    break;
                }
            }

            return coordinates.Count;
        }
    }
}
