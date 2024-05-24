using System;

namespace ECS
{

    namespace System
    {


        namespace dice.input
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
    }
}
