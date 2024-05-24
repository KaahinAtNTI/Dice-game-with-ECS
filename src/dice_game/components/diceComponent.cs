namespace ECS
{

    namespace Component
    {



        namespace Dice
        {
            public class DiceComponent
            {
                public int[] dicevalues { get; } = { 1, 2, 3, 4, 5, 6 };
                public int current_dicevalue = 1;
            }
        }

    }
}