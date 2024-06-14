namespace CSharp.user_input_and_files;


public class Pr_TicTacToe
{
    // Variables
    static char[] spaces = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    static int player = 1;
    static int choice;
    static int flag;

    // Draw Board Method
    static void DrawBoard()
    {
        Console.WriteLine("     |     |     ");
        Console.WriteLine($"  {spaces[0]}  |  {spaces[1]}  |  {spaces[2]}  ");
        Console.WriteLine("_____|_____|_____");
        Console.WriteLine("     |     |     ");
        Console.WriteLine($"  {spaces[3]}  |  {spaces[4]}  |  {spaces[5]}  ");
        Console.WriteLine("_____|_____|_____");
        Console.WriteLine("     |     |     ");
        Console.WriteLine($"  {spaces[6]}  |  {spaces[7]}  |  {spaces[8]}  ");
        Console.WriteLine("     |     |     ");
    }

    
    
    // Check Win Method
    static int CheckWin()
    {
        // Check rows
        for (int i = 0; i < 9; i += 3)
        {
            if (spaces[i] == spaces[i + 1] && spaces[i + 1] == spaces[i + 2])
                return 1;
        }

        // Check columns
        for (int i = 0; i < 3; i++)
        {
            if (spaces[i] == spaces[i + 3] && spaces[i + 3] == spaces[i + 6])
                return 1;
        }

        // Check diagonals
        if ((spaces[0] == spaces[4] && spaces[4] == spaces[8]) || (spaces[2] == spaces[4] && spaces[4] == spaces[6]))
            return 1;

        // Check for tie
        foreach (char c in spaces)
        {
            if (c != 'X' && c != 'O')
                return 0; // Continue playing
        }

        return -1; // Tie
    }

    
    
    
    // Draw X Method
    static void DrawX(int position)
    {
        spaces[position] = 'X';
    }
    
    
    

    // Draw O Method
    static void DrawO(int position)
    {
        spaces[position] = 'O';
    }

    
    
    
    // Tic-Tac-Toe Method
    public static void TicTacToe()
    {
        do
        {
            Console.Clear();
            Console.WriteLine("Player 1: X and Player 2: O" + "\n");

            if (player % 2 == 0)
            {
                Console.WriteLine("Player 2's Turn");
            }
            else
            {
                Console.WriteLine("Player 1's Turn");
            }

            Console.WriteLine("\n");
            DrawBoard();
            choice = int.Parse(Console.ReadLine()) - 1;

            if (spaces[choice] != 'X' && spaces[choice] != 'O')
            {
                if (player % 2 == 0)
                {
                    DrawO(choice);
                }
                else
                {
                    DrawX(choice);
                }

                player++;
            }
            else
            {
                Console.WriteLine($"Sorry, the cell {choice + 1} is already marked with {spaces[choice]} \n");
                Console.WriteLine("Please wait 2 seconds, board is loading again...");
                Thread.Sleep(2000);
            }

            flag = CheckWin();

        } while (flag != 1 && flag != -1);

        Console.ReadLine();
        Console.Clear();
        DrawBoard();

        if (flag == 1)
        {
            Console.WriteLine("Player {0} has won!", (player % 2) + 1);
        }
        else
        {
            Console.WriteLine("Tie Game!");
        }

        Console.ReadLine();
    }
}
