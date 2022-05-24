using AttackSolver.Interfaces;
using Interface;
using System.Drawing;

namespace AttackSolver
{
    public class MyAttackCounter : IAttackCounter
    {
        private readonly IBishopCoordinatesCounter _bishop;
        private readonly IKnightCoordinatesCounter _knight;
        private readonly IRookCoordinatesCounter _rook;

        public MyAttackCounter() { }
        public MyAttackCounter(IBishopCoordinatesCounter bishop, IKnightCoordinatesCounter knight, IRookCoordinatesCounter rook)
        {
            _bishop = bishop;
            _knight = knight;
            _rook = rook;
        }

        public int CountUnderAttack(ChessmanType cmType, Size boardSize, Point startCoords, Point[] obstacles)
        {
            if (cmType == ChessmanType.Rook)
            {
                var path = _rook.GetNumberOfCoordinates(boardSize, startCoords, obstacles);

                return path;
            }

            if (cmType == ChessmanType.Bishop)
            {
                var path = _bishop.GetNumberOfCoordinates(boardSize, startCoords, obstacles);

                return path;
            }

            if (cmType == ChessmanType.Knight)
            {
                var path = _knight.GetNumberOfCoordinates(boardSize, startCoords, obstacles);

                return path;
            }

            return 0;
        }
    }
}
