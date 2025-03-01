# Adventurify - An Adventure Game

## Description

Adventurify is a text-based adventure game built in C# where players can choose a character type and face various challenges throughout the game. Players will navigate through different scenarios based on their choices and test their survival skills.

## Features

- Three playable character types:
    - **Warrior**: Faces battles and must make strategic decisions.
    - **Wizard**: Has magical abilities but must manage magic points wisely.
    - **Archer**: Engages in exploration and survival-based challenges.
- Interactive decision-making system where choices impact the outcome.
- Multiple endings depending on the player's actions.

## How to Play

1. Run the program in a C#-supported environment.
2. Name your character.
3. Choose a character type:
    - Warrior (1)
    - Wizard (2)
    - Archer (3)
4. Make decisions during the game when prompted.
5. Try to survive and win the game!

## Requirements

- .NET Core SDK
- C# compiler
- Console application runtime

## Installation & Execution

1. Clone the repository or copy the `Program.cs` file to your local environment.
2. Open a terminal/command prompt in the project directory.
3. Compile and run the program using:
   ```sh
   dotnet run
   ```
4. Follow the on-screen prompts to play the game.

## Code Structure

- `Main()` function initializes the game and allows the player to choose their character type.
- Separate functions for each character type handle their unique storylines:
    - `warrior()`
    - `wizard()`
    - `archer()`
- Nested functions for different actions and scenarios.

## Known Issues

- Some game logic needs improvement in decision-making.
- The weapon and magic point depletion logic requires corrections.

## Future Enhancements

- Implementing a scoring system.
- Adding more character abilities and story depth.
- Enhancing the game with a graphical user interface (GUI).

## License

This project is open-source and free to use for educational and learning purposes.

## Author

Developed by Arryan Malhotra.