﻿namespace UnitTests;

[TestClass]
public class PostfixCalculatorTests
{

    [TestMethod]
    public void Postfix1()
    {

        Assert.AreEqual(4, PostfixCalculator.Program.Evaluate("2 2 +"));
    }

    [TestMethod]
    public void Postfix2()
    {

        Assert.AreEqual(8, PostfixCalculator.Program.Evaluate("5 3 +"));
    }

    [TestMethod]
    public void Postfix3()
    {

        Assert.AreEqual(2, PostfixCalculator.Program.Evaluate("7 5 -"));
    }

    [TestMethod]
    public void Postfix4()
    {

        Assert.AreEqual(1, PostfixCalculator.Program.Evaluate("5 3 1 + -"));
    }

    [TestMethod]
    public void Postfix5()
    {

        Assert.AreEqual(5, PostfixCalculator.Program.Evaluate("15 7 1 1 + - / 3 * 2 1 1 + + -"));
    }

    [TestMethod]
    public void Postfix6()
    {

        Assert.AreEqual(45, PostfixCalculator.Program.Evaluate("15 7 1 2 + - / 3 * 2 1 1 + + *"));
    }

    [TestMethod]
    public void Postfix7()
    {

        Assert.AreEqual(-3.4, PostfixCalculator.Program.Evaluate("16 15 - 7 1 1 + - / 3 * 2 1 1 + + -"));
    }

    [TestMethod]
    public void Postfix8()
    {

        Assert.AreEqual(1.0 / 6.0, PostfixCalculator.Program.Evaluate("51 32 + 82 - 6 /"));
    }

    [TestMethod]
    public void Postfix9()
    {

        Assert.AreEqual(2030, PostfixCalculator.Program.Evaluate("54 62 + 2 / 35 *"));
    }

    [TestMethod]
    public void Postfix10()
    {

        Assert.AreEqual(23, PostfixCalculator.Program.Evaluate("10 2 8 * + 3 -"));
    }

}

