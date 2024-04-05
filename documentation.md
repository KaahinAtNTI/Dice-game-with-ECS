


Dice Guessing Game Documentation
<b>
Overview
The Dice Guessing Game is a simple console-based game where the player tries to guess the value of a virtual six-sided die. The game is implemented using the Entity-Component-System (ECS) architecture, providing a flexible and modular approach to game development.

Rules
The player is prompted to guess the value of the rolled die.
If the player's guess matches the actual value of the rolled die, they win.
The game allows the player a maximum of 6 attempts to guess the correct value.
Architecture
Entity-Component-System (ECS)
The game utilizes the ECS architecture to manage entities and their behavior. This architecture consists of the following components:

Entity: Represents an object in the game world. Entities are composed of various components that define their behavior and properties.

Component: Defines specific attributes or behavior of an entity. Components are added to entities to give them functionality.

System: Contains the logic that operates on entities with specific components. Systems update the state of entities based on their components.

Components
DiceComponent: Represents the virtual six-sided die. It stores the possible values of the die and the current rolled value.

InputComponent: Handles player input for guessing the value of the die.

Systems
diceChecksystem: Generates a random value for the virtual die and updates the current_dicevalue in the DiceComponent.

InputSystem: Handles user input for guessing the value of the die and updates the guess in the InputComponent.

Usage
Run the program.
The player will be prompted to guess the value of the rolled die.
Enter a number between 1 and 6 representing the guessed value.
If the guessed value matches the actual value of the rolled die, the player wins. Otherwise, they are prompted to guess again.
The game ends after the player guesses correctly or after 6 attempts.
Implementation Details
The game is implemented in C# using a console-based interface.
Random numbers are generated using the Random class.
The game allows only integer inputs for guessing the value of the die.
This documentation provides an overview of the game, its rules, architecture, and usage instructions. It also includes implementation details to give insight into how the game is built.





