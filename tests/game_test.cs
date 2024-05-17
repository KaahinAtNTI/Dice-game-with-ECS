using NUnit.Framework;
using System;
using System.IO;

namespace ECS_dice_game_2.Tests
{
    [TestFixture]
    public class GameTests
    {
        [Test]
        public void GuessCorrectNumber()
        {
            // Arrange
            var player = new Entity(1);
            var fakeInput = new StringReader("3"); // Input the correct number

            Console.SetIn(fakeInput);
            StringWriter output = new StringWriter();
            Console.SetOut(output);

            var diceComponent = new DiceComponent();
            diceComponent.current_dicevalue = 3; // Set the dice value to match the guess
            player.AddComponent(diceComponent);

            InputComponent input = new InputComponent();
            player.AddComponent(input);

            diceChecksystem currentDice = new diceChecksystem();
            InputSystem reader = new InputSystem();

            // Act
            currentDice.diceNumber(player);
            reader.inputNumber(player);

            // Assert
            string expectedOutput = "Guess a number" + Environment.NewLine +
                                    "Du gissade rätt!" + Environment.NewLine;
            Assert.AreEqual(expectedOutput, output.ToString());
        }

        [Test]
        public void GuessWrongNumber()
        {
            // Arrange
            var player = new Entity(1);
            var fakeInput = new StringReader("4"); // Input a wrong number

            Console.SetIn(fakeInput);
            StringWriter output = new StringWriter();
            Console.SetOut(output);

            var diceComponent = new DiceComponent();
            diceComponent.current_dicevalue = 3; // Set the dice value to something different
            player.AddComponent(diceComponent);

            InputComponent input = new InputComponent();
            player.AddComponent(input);

            diceChecksystem currentDice = new diceChecksystem();
            InputSystem reader = new InputSystem();

            // Act
            currentDice.diceNumber(player);
            reader.inputNumber(player);

            // Assert
            string expectedOutput = "Guess a number" + Environment.NewLine +
                                    "Du gissade fel, gissa igen" + Environment.NewLine;
            Assert.AreEqual(expectedOutput, output.ToString());
        }
    }
}
