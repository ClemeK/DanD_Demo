using DanD_Demo;
using Spectre.Console;
using static System.Console;

/*
* Title:   DandD_Demo
* Author:  Kelvin Clements
* Date:    22-Jan-2023
* Purpose: To writa a d& d game using a state engin
* 
* LOG ------------------------------------------------------
* DD/MMM/YYYY   Comments ....................................
* ----------------------------------------------------------
* 22-Jan-2023 - Project started
*   -Aug-2025 - Change program to use Spectre Graphics

*/


int room = 0;
string ans;
Player player1 = new();

if (args.Length > 0)
{
    if (args[0].ToLower() == "/spectre")
    {
        GL.spectre = true;
    }
    else
    {
        GL.spectre = false;
    }
}
else
{
    GL.spectre = false;
}

// Set this to test the spectre option
GL.spectre = true;

General.StartCredits();
General.Pause();

General.Heading();

ans = General.InputYesNo("Do you wish to start a new game");

if (ans == "Y") // Start new game
{
    string name = General.InputString("What is your name", "*");

    // Create Player
    player1.New();
    player1.Name = name.Capitalize();

    // Reset to start of game
    General.LoadRoom(true);

    // Choose spells
    if (GL.spectre == true)
    {
        General.SelectSpellsSpectre(player1, player1.GetInitialMagic());
    }
    else
    {
        General.SelectSpells(player1, player1.GetInitialMagic());
    }
    player1.Save();
}
else // Load old game
{
    player1.Load();
    if (GL.spectre == true)
    {
        AnsiConsole.Write(new Markup($"Welcome back ", GL.greenOnBlack));
        AnsiConsole.Write(new Markup($"{player1.Name}./n", GL.blueOnBlack));
    }
    else
    {
        WriteLine($"Welcome back {player1.Name}.\n");
    }

    // Load the game position
    room = General.LoadRoom(false);
}

// Game goes here
TheGame.PlayGame(GL.room, player1);

// Exit the game
General.EndCredits();
// ***** T h e   E n d *****

public class GL
{
    public static bool spectre = false;
    public static int room;

    public static Style aquaOnBlack = new(
                   foreground: Color.Aqua,
                   background: Color.Black
                   );

    public static Style blueOnBlack = new(
                 foreground: Color.Blue,
                 background: Color.Black
                 );

    public static Style cyanOnBlack = new(
                  foreground: Color.Cyan1,
                  background: Color.Black
                  );

    public static Style danger = new(
                   foreground: Color.Red,
                   background: Color.White,
                   decoration: Decoration.Bold | Decoration.Italic
                   );

    public static Style greenOnBlack = new(
                  foreground: Color.Green,
                  background: Color.Black
                  );

    public static Style redOnBlack = new(
                   foreground: Color.Red,
                   background: Color.Black
                   );

    public static Style redOnwhite = new(
                  foreground: Color.Red,
                  background: Color.White
                  );

    public static Style player1 = new(
                   foreground: Color.Blue,
                   background: Color.Black
                   );

    public static Style yellowOnBlack = new(
                   foreground: Color.Yellow,
                   background: Color.Black
                   );

    public static Style whiteOnBlack = new(
                   foreground: Color.White,
                   background: Color.Black
                   );
}