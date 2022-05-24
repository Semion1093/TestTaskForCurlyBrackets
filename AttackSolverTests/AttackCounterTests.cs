using AttackSolver;
using AttackSolver.Interfaces;
using AttackSolver.Tests.TestCaseSource;
using Interface;
using Moq;
using NUnit.Framework;
using System.Drawing;

namespace AttackSolverTests
{
    public class AttackCounterTests
    {
        private Mock<IRookCoordinatesCounter> _rookMock;
        private Mock<IBishopCoordinatesCounter> _bishopMock;
        private Mock<IKnightCoordinatesCounter> _knightMock;
        private MyAttackCounter _attackCounter;

        [SetUp]
        public void Setup()
        {
            _rookMock = new Mock<IRookCoordinatesCounter>();
            _bishopMock = new Mock<IBishopCoordinatesCounter>();
            _knightMock = new Mock<IKnightCoordinatesCounter>();
            _attackCounter = new MyAttackCounter(_bishopMock.Object, _knightMock.Object, _rookMock.Object);
        }

        [TestCaseSource(typeof(CountUnderAttack_Rook_TestCaseSource))]
        public void CountUnderAttack_Rook_ShouldReturnNumberOfSquares(
            Size boardSize, Point startCoords, Point[] obstacles, ChessmanType cmType, int expected)
        {
            //given
            _rookMock.Setup(x => x.GetNumberOfCoordinates(boardSize, startCoords, obstacles)).Returns(4);

            //when
            var actual = _attackCounter.CountUnderAttack(cmType, boardSize, startCoords, obstacles);

            //then
            Assert.That(expected, Is.EqualTo(actual));
            _rookMock.Verify(x => x.GetNumberOfCoordinates(boardSize, startCoords, obstacles), Times.Once);
        }

        [TestCaseSource(typeof(CountUnderAttack_Bishop_TestCaseSource))]
        public void CountUnderAttack_Bishop_ShouldReturnNumberOfSquares(
            Size boardSize, Point startCoords, Point[] obstacles, ChessmanType cmType, int expected)
        {
            //given
            _bishopMock.Setup(x => x.GetNumberOfCoordinates(boardSize, startCoords, obstacles)).Returns(4);

            //when
            var actual = _attackCounter.CountUnderAttack(cmType, boardSize, startCoords, obstacles);

            //then
            Assert.That(expected, Is.EqualTo(actual));
            _bishopMock.Verify(x => x.GetNumberOfCoordinates(boardSize, startCoords, obstacles), Times.Once);
        }

        [TestCaseSource(typeof(CountUnderAttack_Knight_TestCaseSource))]
        public void CountUnderAttack_Knight_ShouldReturnNumberOfSquares(
            Size boardSize, Point startCoords, Point[] obstacles, ChessmanType cmType, int expected)
        {
            //given
            _knightMock.Setup(x => x.GetNumberOfCoordinates(boardSize, startCoords, obstacles)).Returns(4);

            //when
            var actual = _attackCounter.CountUnderAttack(cmType, boardSize, startCoords, obstacles);

            //then
            Assert.That(expected, Is.EqualTo(actual));
            _knightMock.Verify(x => x.GetNumberOfCoordinates(boardSize, startCoords, obstacles), Times.Once);
        }
    }
}