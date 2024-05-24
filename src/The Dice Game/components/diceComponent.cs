namespace ECS_dice_game_2
{
    public class DiceComponent
    {
        public int[] dicevalues { get; } = { 1, 2, 3, 4, 5, 6 };
        public int current_dicevalue = 1;
    }
}
