using ECS.Entities;
using ECS.Components;
using System;

namespace ECS.Systems
{
    public class InputSystem
    {
        public void InputNumber(Entity entity)
        {
            InputComponent inputComponent = entity.GetComponent<InputComponent>();
            if (inputComponent == null)
            {
                throw new InvalidOperationException("InputComponent is required but was not found on the entity.");
            }

            Console.WriteLine("Please enter a number:");  
            string input = Console.ReadLine();

            try
            {
                inputComponent.Guess = Convert.ToInt32(input);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("The number entered is too large or too small.");
            }
        }
    }
}
