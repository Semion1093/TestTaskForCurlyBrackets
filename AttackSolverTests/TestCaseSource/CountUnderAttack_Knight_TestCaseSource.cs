using Interface;
using System.Collections;
using System.Drawing;

namespace AttackSolver.Tests.TestCaseSource
{
    public class CountUnderAttack_Knight_TestCaseSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            Size boardSize = new(10, 10);
            Point startCoords = new(2, 3);
            var obstacles = new Point[] { new Point(1, 1), new Point(1, 3) };
            var cmType = ChessmanType.Knight;
            var expected = 4;

            yield return new object[] { boardSize, startCoords, obstacles, cmType, expected };
        }
    }
}
