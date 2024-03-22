using System;
using System.Collections.Generic;

namespace ECS_dice_game_2
{
    public class DiceComponent
    {
        public int[] dicevalues { get; } = { 1, 2, 3, 4, 5, 6 };
        public int current_dicevalue = 1;
    }

    public class Entity
    {
        public int Id;

        private Dictionary<Type, object> components = new Dictionary<Type, object>();

        public Entity(int id)
        {
            Id = id;
        }

        public void AddComponent<T>(T component)
        {
            components[typeof(T)] = component;
        }

        public T GetComponent<T>() where T : class
        {
            if (components.TryGetValue(typeof(T), out var component))
            {
                return component as T;
            }
            return null;
        }
    }

    public class diceChecksystem
    {
        DiceComponent diceComponent = new DiceComponent();
        public void diceNumber(Entity entity)
        {
            var dicecomponent = entity.GetComponent<DiceComponent>();
            Random rnd = new Random();
            dicecomponent.current_dicevalue = rnd.Next(1, dicecomponent.dicevalues.Length + 1);
        }
    }

    public class InputComponent
    {
        public Int32 guess = 0;
    }

    public class InputSystem
    {
        public void inputNumber(Entity entity)
        {
            InputComponent inputComponent = entity.GetComponent<InputComponent>();
           
            inputComponent.guess = Convert.ToInt32(Console.ReadLine());
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var player = new Entity(1);
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Guess a number");

            DiceComponent diceComponent = new DiceComponent();
            InputComponent input = new InputComponent();

            player.AddComponent(diceComponent); // Lägga till componenter till entity
            player.AddComponent(input);

            diceChecksystem currentDice = new diceChecksystem();
            InputSystem reader = new InputSystem();

            currentDice.diceNumber(player); // Generera slumpmässiga nummer för tärningen

            reader.inputNumber(player); // Ta input från användaren.
           
                int guess = player.GetComponent<InputComponent>().guess;
                int actualDiceValue = player.GetComponent<DiceComponent>().current_dicevalue;

           

                if (guess == actualDiceValue)
                {
                    Console.WriteLine("Du gissade rätt!");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Du gissade fel, gissa igen");
                    
                }
            }
        }
    }
}
