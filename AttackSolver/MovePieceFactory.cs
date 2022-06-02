using AttackSolver.Interfaces;
using Interface;
using System;

namespace AttackSolver
{
    public class MovePieceFactory : IMovePieceFactory
    {
        public IMovePiece GetMovePiece(ChessmanType chessmanType)
        {
            switch (chessmanType)
            {
                case ChessmanType.Rook:
                    return new RookCoordinatesCounter();

                case ChessmanType.Bishop:
                    return new BishopCoordinatesCounter();

                case ChessmanType.Knight:
                    return new KnightCoordinatesCounter();

                default:
                    throw new ArgumentException("Such type of piece wasn't found");
            }
        }
    }
}
