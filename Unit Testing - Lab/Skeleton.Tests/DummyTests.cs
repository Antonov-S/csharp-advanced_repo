using NUnit.Framework;
using System;

[TestFixture]
public class DummyTests
{
    [Test]
    public void DummyShoudLosesHealthIfIsAttacked()
    {
        // Arrange
        Dummy dummy = new Dummy(100, 100);

        // Act
        dummy.TakeAttack(10);

        // Assert
        var expectedResult = 90;
        var actualResult = dummy.Health;

        Assert.AreEqual(expectedResult, actualResult);
    }

    [Test]
    public void DeadDummyShoudThrowsExceptionIfIsAttacked()
    {
        // Arrange
        Dummy dummy = new Dummy(0, 100);

        // Act - Assert

        Assert.Throws<InvalidOperationException>(() => dummy.TakeAttack(10));
    }

    [Test]
    public void DeadDummyShoudGiveXP()
    {
        // Arrange
        Dummy dummy = new Dummy(0, 100);

        // Act - Assert
        var actualResult = dummy.GiveExperience();
        var expectedResult = 100;
        Assert.AreEqual(expectedResult, actualResult);
    }

    [Test]
    public void AliveDummyShudNotGiveXP()
    {
        // Arrange
        Dummy dummy = new Dummy(100, 100);

        // Act - Assert
        Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience());
    }
}
