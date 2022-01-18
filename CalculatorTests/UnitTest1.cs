using NUnit.Framework;
using Calc;
namespace CalculatorTests;

public class Tests
{
    [Test]
    public void PassingTest()
    {
        Assert.AreEqual(4, Calculator.Add(2,2));
    }

    [Test]
    public void FailingTest()
    {
        Assert.AreNotEqual(5, Calculator.Add(2,2));
    }
}