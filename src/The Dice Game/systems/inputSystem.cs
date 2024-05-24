using System;

namespace ECS_dice_game_2
{
    public class InputSystem
    {
        public void InputNumber(Entity entity)
        {
            InputComponent inputComponent = entity.GetComponent<InputComponent>();
            inputComponent.guess = Convert.ToInt32(Console.ReadLine());
        }
    }
}
