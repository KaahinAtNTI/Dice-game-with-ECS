namespace ECS.Components
{
    public class DiceComponent
    {
        public int CurrentDiceValue { get; set; } = 1;
        public int[] DiceValues { get; } = { 1, 2, 3, 4, 5, 6 };
    }
}
