Checkers Game with WPF GUI using MVVM Pattern

Description:

The Checkers Game application is developed in C# with a WPF GUI using the MVVM design pattern. It provides a graphical interface for playing checkers between two players, where one player controls the red pieces and the other controls the white pieces.

Game Rules and Features:

1.Initial Setup: 
The game starts with the default configuration of the checkers board, consisting of 8 rows and 8 columns. 
Red player makes the first move.

2.Piece Movement:
Players take turns making moves.

  Normal moves: A player can move their piece diagonally forward to an empty adjacent square.

  King transformation: When a piece reaches the opponent's end of the board, it becomes a "king" and gains the ability to move both forwards and backwards diagonally.

  Capture: If a player's piece is adjacent to an opponent's piece and the square beyond it is empty, the player can jump over the opponent's piece and capture it. Multiple consecutive captures are allowed if   possible.

3.Multiple Jump Option: 
Players can enable or disable the multiple jump option at the beginning of the game. If enabled, a player must perform multiple jumps if possible. 
Multiple jumps continue until no more captures are possible.

4.End of Game: 
The game ends when one player has no more pieces left on the board. 
The opponent with remaining pieces is declared the winner.

5.Visual Interface:
The game interface displays the checkers board and highlights the active player. 
It also shows the number of pieces remaining for each player.

6.Save and Load Game:
Players can save the current state of the game to a file and load it later to continue playing. 
The saved file contains the game state and the player who has the next move.

7.Statistics:
The application keeps track of the number of wins for both red and white players.
Statistics, including the maximum number of pieces remaining for the winning player, are displayed in the menu.

8.Menu Options:

  File Menu:

  New Game: Starts a new game with standard settings.

  Save: Saves the current game state to a file.

  Open: Opens a previously saved game configuration.

  Allow Multiple Jump: Toggles the option for multiple jumps.

  Statistics: Displays the number of wins for red and white players and the maximum remaining pieces in a game.

  Help Menu:

  About: Provides information about the creator of the program, institutional email address, group, and a brief description of the game.

The Checkers Game application offers a user-friendly interface for playing checkers while adhering to the MVVM design pattern principles and utilizing data binding. It provides a comprehensive gaming experience with various features, including save/load functionality, statistics tracking, and customizable game settings.
