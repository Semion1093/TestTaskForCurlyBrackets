using System.Drawing;

namespace AttackSolver.Interfaces
{
    public interface IKnightCoordinatesCounter
    {
        int GetNumberOfCoordinates(Size boardSize, Point startCoords, Point[] obstacles);
    }
}