using System.Drawing;

namespace AttackSolver.Interfaces
{
    public interface IBishopCoordinatesCounter
    {
        int GetNumberOfCoordinates(Size boardSize, Point startCoords, Point[] obstacles);
    }
}