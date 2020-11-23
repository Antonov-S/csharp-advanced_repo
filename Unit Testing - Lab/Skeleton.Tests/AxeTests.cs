using NUnit.Framework;
using System;

[TestFixture]
public class AxeTests
{
    [Test]
    [TestCase(100, 100, 100, 100, 99)]
    [TestCase(45, 45, 45, 45, 44)]

    public void WeaponShoudLosesDurabilityAfterAttack(
        int health, 
        int exp, 
        int attack, 
        int durability, 
        int expectedresult)
    {
        // Arrange
        Axe axe = new Axe(attack, durability);
        Dummy dummy = new Dummy(health, exp);

        // Act
        axe.Attack(dummy);

        // Assert
        int expectedResult = expectedresult;
        int actualresult = axe.DurabilityPoints;
        Assert.That(axe.DurabilityPoints, Is.EqualTo(expectedresult), "Axe Durability doesn't change after attack.");
    }

    [Test]

    public void ThrowExepcionIfTryToAttackWithBrokenWepon()
    {
        // Arange
        Dummy dummy = new Dummy(100, 100);
        Axe axe = new Axe(10, 0);

        // Act - Assert
        Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
               

    }
}