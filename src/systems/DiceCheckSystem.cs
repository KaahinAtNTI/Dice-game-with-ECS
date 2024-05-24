using ECS.Entities;
using ECS.Components;
using System;

namespace ECS.Systems
{
    public class DiceCheckSystem
    {
        private readonly Random rnd = new Random();

        public void DiceNumber(Entity entity)
        {
            var diceComponent = entity.GetComponent<DiceComponent>();
            if (diceComponent == null || diceComponent.DiceValues == null || diceComponent.DiceValues.Length == 0)
            {
                throw new InvalidOperationException("DiceComponent and its values must be properly initialized.");
            }

            diceComponent.CurrentDiceValue = rnd.Next(1, diceComponent.DiceValues.Length + 1);
        }
    }
}
