using AttackSolver;
using Interface;
using NUnit.Framework;
using System.Drawing;

namespace AttackSolverTests
{
    public class AttackCounterTests
    {
        private MovePieceFactory _movePieceFactory;
        private AttackCounter _attackCounter;

        [SetUp]
        public void Setup()
        {
            _movePieceFactory = new MovePieceFactory();
            _attackCounter = new AttackCounter(_movePieceFactory);
        }

        [Test]
        public void CountUnderAttack_Rook_ShouldReturnNumberOfSquares()
        {
            //given 
            Size boardSize = new(10, 10);
            Point startCoords = new(2, 2);
            var obstacles = new Point[] { new Point(2, 5), new Point(5, 2) };
            var expected = 6;

            //when
            var actual = _attackCounter.CountUnderAttack(ChessmanType.Rook, boardSize, startCoords, obstacles);

            //then
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void CountUnderAttack_Bishop_ShouldReturnNumberOfSquares()
        {
            //given
            Size boardSize = new(10, 10);
            Point startCoords = new(2, 2);
            var obstacles = new Point[] { new Point(5, 5) };
            var expected = 5;

            //when
            var actual = _attackCounter.CountUnderAttack(ChessmanType.Bishop, boardSize, startCoords, obstacles);

            //then
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void CountUnderAttack_Knight_ShouldReturnNumberOfSquares()
        {
            //given
            Size boardSize = new(10, 10);
            Point startCoords = new(2, 3);
            var obstacles = new Point[] { new Point(1, 1), new Point(3, 1) };
            var expected = 4;
            var actual = _attackCounter.CountUnderAttack(ChessmanType.Knight, boardSize, startCoords, obstacles);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}