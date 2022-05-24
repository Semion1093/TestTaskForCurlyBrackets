using Interface;
using System.Collections;
using System.Drawing;

namespace AttackSolver.Tests.TestCaseSource
{
    public class CountUnderAttack_Bishop_TestCaseSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            Size boardSize = new(10, 10);
            Point startCoords = new(2, 2);
            var obstacles = new Point[] { new Point(5, 5) };
            var cmType = ChessmanType.Bishop;
            var expected = 4;

            yield return new object[] { boardSize, startCoords, obstacles, cmType, expected };
        }
    }
}
