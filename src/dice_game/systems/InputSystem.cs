using ECS.Entities;

namespace ECS.Systems
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
    
