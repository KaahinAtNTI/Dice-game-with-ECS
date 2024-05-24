using NUnit.Framework;
using ECS.Components;

[TestFixture]
public class InputComponentTests
{
    [Test]
    public void TestGuessProperty()
    {
        var inputComponent = new InputComponent();
        inputComponent.Guess = 5;
        Assert.AreEqual(5, inputComponent.Guess);
    }
}

[TestFixture]
public class DiceComponentTests
{
    [Test]
    public void TestCurrentDiceValueProperty()
    {
        var diceComponent = new DiceComponent();
        diceComponent.CurrentDiceValue = 3;
        Assert.AreEqual(3, diceComponent.CurrentDiceValue);
    }

    [Test]
    public void TestDiceValuesProperty()
    {
        var diceComponent = new DiceComponent();
        Assert.AreEqual(new int[] { 1, 2, 3, 4, 5, 6 }, diceComponent.DiceValues);
    }
}