using System.Drawing;

namespace AttackSolver.Interfaces
{
    public interface IRookCoordinatesCounter
    {
        int GetNumberOfCoordinates(Size boardSize, Point startCoords, Point[] obstacles);
    }
}