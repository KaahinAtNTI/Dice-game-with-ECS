using System;

namespace ECS_dice_game_2
{
    public class DiceCheckSystem
    {
        public void DiceNumber(Entity entity)
        {
            var diceComponent = entity.GetComponent<DiceComponent>();
            Random rnd = new Random();
            diceComponent.current_dicevalue = rnd.Next(1, diceComponent.dicevalues.Length + 1);
        }
    }
}
