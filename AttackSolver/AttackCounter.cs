using AttackSolver.Interfaces;
using Interface;
using System.Drawing;

namespace AttackSolver
{
    public class AttackCounter : IAttackCounter
    {
        private readonly IMovePieceFactory _factory;

        public AttackCounter(IMovePieceFactory factory)
        {
            _factory = factory;
        }

        public int CountUnderAttack(ChessmanType cmType, Size boardSize, Point startCoords, Point[] obstacles)
        {
            return _factory.GetMovePiece(cmType).GetAvaliableCoordinatesCount(boardSize, startCoords, obstacles);
        }
    }
}
