using System;
using Xunit;

namespace QuadraticSolver.Tests
{
    public class SolverTests
    {
        [Fact]
        public void NoRealRoots()
        {
            var result = Solver.SolveQuadratic(1, 0, 1); // Discriminant < 0
            Assert.Null(result.Roots);
            Assert.Equal("No real roots.", result.Message);
        }

        [Fact]
        public void OneRealRoot()
        {
            var result = Solver.SolveQuadratic(1, 2, 1); // Discriminant = 0
            Assert.Single(result.Roots);
            Assert.Equal(-1, result.Roots[0]);
            Assert.Equal("One real root.", result.Message);
        }

        [Fact]
        public void TwoRealRoots()
        {
            var result = Solver.SolveQuadratic(1, -3, 2); // Discriminant > 0
            Assert.Equal(2, result.Roots.Length);
            Assert.Contains(2, result.Roots);
            Assert.Contains(1, result.Roots);
            Assert.Equal("Two real roots.", result.Message);
        }

        [Fact]
        public void NotAQuadratic()
        {
            var result = Solver.SolveQuadratic(0, 2, 1); // a = 0
            Assert.Null(result.Roots);
            Assert.Equal("Not a quadratic equation.", result.Message);
        }
    }
}
