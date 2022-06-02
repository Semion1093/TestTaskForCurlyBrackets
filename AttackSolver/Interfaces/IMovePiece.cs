using System.Drawing;

namespace AttackSolver.Interfaces
{
    public interface IMovePiece
    {
        int GetAvaliableCoordinatesCount(Size boardSize, Point startCoords, Point[] obstacles);
    }
}
