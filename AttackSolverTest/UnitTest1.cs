using AttackSolver;
using AttackSolver.Interfaces;
using Interface;
using Moq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using Xunit;
using Xunit.Abstractions;

namespace AttackSolverTest
{
    public class UnitTest1
    {
        private readonly ITestOutputHelper output;
        private readonly RookCoordinatesCounter _rook;
        private readonly BishopCoordinatesCounter _bishop;
        private readonly KnightCoordinatesCounter _knight;
        private readonly MyAttackCounter _attackCounter;
        private readonly MovePieceFactory _movePieceFactory;

        public UnitTest1(ITestOutputHelper output)
        {
            this.output = output;
            _rook = new RookCoordinatesCounter();
            _bishop = new BishopCoordinatesCounter();
            _knight = new KnightCoordinatesCounter();
            _movePieceFactory = new MovePieceFactory();
            _attackCounter = new MyAttackCounter(_movePieceFactory);
        }

        [Fact]
        public void Test1()
        {
            var insts = FindImplementations();
            if (insts.Count == 0)
                throw new Exception(
                    "No implementation of IAttackCounter was found, make sure you add a reference to your project to AttackSolverTest");

            foreach (var inst in insts)
            {
                output.WriteLine("Testing " + inst.GetType().FullName);
                // Rook - ladja
                var res = _attackCounter.CountUnderAttack(ChessmanType.Rook, new Size(3, 2), new Point(1, 1),
                    new[] { new Point(2, 2), new Point(1, 3) });
                Assert.Equal(3, res);

                // Bishop - slon
                res = _attackCounter.CountUnderAttack(ChessmanType.Bishop, new Size(4, 5), new Point(2, 2),
                    new[] { new Point(3, 3), new Point(1, 3) });
                Assert.Equal(2, res);

                // Knight - kon'
                res = _attackCounter.CountUnderAttack(ChessmanType.Bishop, new Size(4, 5), new Point(1, 1),
                    new[] { new Point(3, 2), });
                Assert.Equal(1, res);
            }
        }

        IList<IAttackCounter> FindImplementations()
        {
            return AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(mytype => mytype.GetInterfaces().Contains(typeof(IAttackCounter)))
                .Select(type => (IAttackCounter)Activator.CreateInstance(type)).ToList();
        }
    }
}
