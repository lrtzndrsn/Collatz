using NUnit.Framework;
using Collatz;

namespace Collatz.Tests;

public class Tests {
    [Test]
    public void CollatzHasStatementCoverage() {
        Assert.AreEqual(1, Collatz.CollatzMethods.Collatz(3, 1, 11));
    }

    [Test]
    public void CollatzHasBranchCoverage() {
        Assert.AreEqual(1, Collatz.CollatzMethods.Collatz(3, 1, 11));
        Assert.AreEqual(0, Collatz.CollatzMethods.Collatz(0, 1, 1));
    }

    [Test]
    public void CollatzHasPathCoverageK2() {
        Assert.AreEqual(0, Collatz.CollatzMethods.Collatz(0, 1, 3));
        for (int n = 1; n <= 2; n++) {
            Assert.AreEqual(1, Collatz.CollatzMethods.Collatz(n, 1, n * 3));
        }
    }

    [Test]
    public void CollatzAndCollatzRecAreEquivalentForK1000() {
        for (int n = 0; n < 1000; n++) {
            Assert.AreEqual(Collatz.CollatzMethods.Collatz(n, 1, n * 3), Collatz.CollatzMethods.CollatzRec(n, 1, n * 3));
        }
    }

    [Test]
    public void CollatzReturnsOneForK1000() {
        for (int n = 1; n < 1000; n++) {
            Assert.AreEqual(1, Collatz.CollatzMethods.Collatz(n, 1, n * 3));
        }
    }

    [Test]
    public void CollatzRecReturnsOneForK1000() {
        for (int n = 1; n < 1000; n++) {
            Assert.AreEqual(1, Collatz.CollatzMethods.CollatzRec(n, 1, n * 3));
        }
    }
}