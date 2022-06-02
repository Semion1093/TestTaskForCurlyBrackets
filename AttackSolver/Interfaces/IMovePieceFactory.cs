using Interface;

namespace AttackSolver.Interfaces
{
    public interface IMovePieceFactory
    {
        IMovePiece GetMovePiece(ChessmanType chessmanType);
    }
}
