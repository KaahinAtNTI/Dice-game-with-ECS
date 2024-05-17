using System;
using System.Collections.Generic;

namespace ECS_dice_game_2
{
    public class DiceComponent
    {
        // Sätter alla de olika tärningsvärden
        public int[] dicevalues { get; } = { 1, 2, 3, 4, 5, 6 };
        //Bestämmer att den nuvarande nummret är 1 från start
        public int current_dicevalue = 1;
    }
    // Här har vi entity
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
    // Här är systemet för att kolla tärningarna
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
        // Här är spelarens gissning (innan man gissat)
        public Int32 guess = 0;
    }

    public class InputSystem
    {
        public void inputNumber(Entity entity)
        {
            InputComponent inputComponent = entity.GetComponent<InputComponent>();
            // Här tar man input för spelarens gissning.
            inputComponent.guess = Convert.ToInt32(Console.ReadLine());
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Här skapar vi spelaren
            var player = new Entity(1);

            // Vi skapar en for loop som skap loopa max 6 gånger om man har fel.
            for (int i = 0; i < 6; i++)
            {
                // Konsolen ber spelaren att gissa på ett nummer.
                Console.WriteLine("Guess a number");
            // Hämtar de olika komponenterna
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

           

                if (guess == actualDiceValue) // Kollar om gissningen stämmer överens med vad tärningens värde är.
                {
                    Console.WriteLine("Du gissade rätt!"); // Printar ut att man hade rätt.
                    Environment.Exit(0); // Konsolen stängs ner automatiskt.
                }
                else
                {
                    // printar ut att man har fel
                    Console.WriteLine("Du gissade fel, gissa igen"); // Man kommer att loopas till baka som max 6 gånger om man har fel. Antingen tills man har rätt eller tills man loopats 6 gånger.
                    
                }
            }
        }
    }
}
