// Include namespace system
using System;
using System.IO;
using System.Threading;

public class Program
{
    public static void Main(string[] args)
    {
        PlayMazeGame();
    }
    public static void PlayMazeGame()
    {
        String userInput = "";
        while (string.CompareOrdinal(userInput.ToUpper(), "Q") != 0)
        {
            Console.WriteLine("Which level do you want to try?");
            Console.WriteLine("1. Reach the finish line");
            Console.WriteLine("2. All commands up front");
            Console.WriteLine("3. Hack the path");
            Console.WriteLine("4. Reach the finish line Random");
            Console.WriteLine("5. All commands up front Random");
            Console.WriteLine("6. Hack the path Random");
            Console.WriteLine("7. You are Neo");
            Console.WriteLine("Q. Quit");
            Console.Write("> ");
            userInput = Console.ReadLine().ToUpper();
            if (string.CompareOrdinal(userInput, "1") == 0)
            {
                Program.Level1();
            }
            if (string.CompareOrdinal(userInput, "2") == 0)
            {
                Program.Level2();
            }
            if (string.CompareOrdinal(userInput, "3") == 0)
            {
                Program.Level3();
            }
            if (string.CompareOrdinal(userInput, "4") == 0)
            {
                Program.Level4();
            }
            if (string.CompareOrdinal(userInput, "5") == 0)
            {
                Program.Level5();
            }
            if (string.CompareOrdinal(userInput, "6") == 0)
            {
                Program.Level6();
            }
            if (string.CompareOrdinal(userInput, "7") == 0)
            {
                Program.Level7();
            }
        }
    }
    public static void Level1()
    {
        // This is the maze, it's stored as a 2-d array.
        // 0 = Empty spot
        // 1 = You facing north
        // 2 = You facing east
        // 3 = You facing south
        // 4 = You facing west
        // 5 = Finish line
        // 6 = Obstacle Cactus

        int[,] m = { { 6, 6, 0, 0, 0 }, { 0, 0, 6, 0, 6 }, { 0, 6, 5, 0, 0 }, { 0, 1, 6, 6, 0 }, { 0, 0, 0, 0, 0 } };
        Program.PlayManualUnlimited(m);
        Console.WriteLine("Congratulations! Secret message: " + SecretPassword("ZBMHTNGYYEHNNKCBMVASLCUHRCSTVNLGTPXOYUTGKX"));
        PressEnterToContinue();
    }
    public static void Level2()
    {
        // This is the maze, it's stored as a 2-d array.
        // 0 = Empty spot
        // 1 = You facing north
        // 2 = You facing east
        // 3 = You facing south
        // 4 = You facing west
        // 5 = Finish line
        // 6 = Obstacle
        //int[,] m = CreateMap(5,5);
        int[,] m = {{5,0,0,6,0,0,0,0,0,0},
                {6,6,0,6,6,6,0,6,6,6},
                {0,6,0,6,0,0,0,0,0,0},
                {0,6,0,6,0,6,6,6,0,0},
                {0,6,0,6,0,0,0,6,0,0},
                {0,6,0,6,6,0,0,6,0,0},
                {0,6,0,6,0,0,6,6,0,0},
                {0,0,0,0,0,0,6,0,0,0},
                {0,6,0,6,6,0,6,0,6,6},
                {0,6,0,6,0,0,6,0,0,1}};
        Program.PlayManualOnce(m);
        int[] coordinate = Program.find(m, 5);
        if (coordinate == null)
        {
            Console.WriteLine("Congratulations! Secret message: " + SecretPassword("HVFPERTCMKXRUMRCDEBNXDXVUDDGRCLVHMTIAHHMRCRNLPUR"));
        }
        else
        {
            Console.WriteLine("Fail, try again");
        }
        Console.WriteLine();
    }
    public static void Level3()
    {
        Program.ClearScreen();
        int[,] m = {{5,0,0,6,0,0,0,0,0,0},
                 {6,6,0,6,6,6,0,6,6,6},
                 {0,6,0,6,0,0,0,0,0,0},
                 {0,6,0,6,0,6,6,6,0,0},
                 {0,6,0,6,0,0,0,6,0,0},
                 {0,6,0,6,6,0,0,6,0,0},
                 {0,6,0,6,0,0,6,6,0,0},
                 {0,0,0,0,0,0,6,0,0,0},
                 {0,6,0,6,6,0,6,0,6,6},
                 {0,6,0,6,0,0,6,0,0,1}};
        // Write your code here, between the comments

        MoveForward(m);
        MoveForward(m);
        TurnRight(m);
        MoveForward(m);
        MoveForward(m);
        TurnRight(m);
        MoveForward(m);
        TurnLeft(m);
        MoveForward(m);
        MoveForward(m);
        MoveForward(m);
        MoveForward(m);
        MoveForward(m);
        MoveForward(m);
        TurnLeft(m);
        MoveForward(m);
        MoveForward(m);
        MoveForward(m);
        MoveForward(m);
        TurnLeft(m);
        // Do not change the code below this line.
        Program.PrintMap(m);
        Console.WriteLine("Level 3: This level requires code hacking! (Changing the code in the compiler.)");
        Console.WriteLine("In this level, you must write your action out in code and replay this level.");
        Console.WriteLine("Find the level3() function, and use the TurnLeft(), TurnRight(), and MoveForward() functions.\n");
        int[] coordinate = Program.find(m, 5);
        if (coordinate == null)
        {
            Console.WriteLine("Congratulations! Secret message: " + SecretPassword("STHOMAWWZLYFAAYVYAJIYWEPZLKCSIEQPUOEZQDEYOOTKYTXLYEVEKX"));
        }
        else
        {
            Console.WriteLine("Fail, try again!");
        }
        Program.PressEnterToContinue();
    }
    public static void Level4()
    {
        int[,] m = CreateMap(10, 10);
        Program.PlayManualUnlimited(m);
        Console.WriteLine("Congratulations! Secret message: " + SecretPassword("OAQXJDAKEDWPTDEPHPSEXGOIWBMIZLEJKD"));
        Program.PressEnterToContinue();
    }
    public static void Level5()
    {
        int[,] m = CreateMap(10, 10);
        Program.PlayManualOnce(m);
        int[] coordinate = Program.find(m, 5);
        if (coordinate == null)
        {
            Console.WriteLine("Congratulations! Secret message: " + SecretPassword("BCMWVHGZCHRWOTOURXOGKRVEFWYWKJ"));
        }
        else
        {
            Console.WriteLine("Fail, try again!");
        }
        Program.PressEnterToContinue();
    }
    public static void Level6()
    {
        Program.ClearScreen();
        int[,] m = CreateMap(10, 10);
        // Write your code here, between the comments:


        // Do not change the code below this line.
        Program.PrintMap(m);
        Console.WriteLine("Level 6: This level requires code hacking! (Changing the code in the compiler.)");
        Console.WriteLine("In this level, you must write your action out in code and replay this level.");
        Console.WriteLine("Find the level6() function, and use the TurnLeft(), TurnRight(), and MoveForward() functions.\n");
        int[] coordinate = Program.find(m, 5);
        if (coordinate == null)
        {
            Console.WriteLine("Congratulations! Secret message: " + SecretPassword("TPTMJVMLEILVONAGAENJOIOUDTCHXGOHAGIA"));
        }
        else
        {
            Console.WriteLine("Fail, try again!");
        }
        Program.PressEnterToContinue();
    }
    public static void Level7()
    {
        Program.ClearScreen();
        int[,] m = { { 1, 6, 5, 0, 0 }, { 6, 6, 6, 0, 6 }, { 0, 6, 0, 0, 6 }, { 6, 6, 6, 6, 0 }, { 0, 6, 0, 0, 0 } };
        // Do not change the code below this line.
        Program.PrintMap(m);
        Console.WriteLine("Level 7: This level requires code hacking! (Changing the code in the compiler.)");
        Console.WriteLine("In this level, you are trapped in the matrix like Neo.");
        Console.WriteLine("Find the level7() function, and change the underlying maze data so that you can escape.");
        Program.PressEnterToContinue();
        Program.PlayManualUnlimited(m);
        int[] coordinate = Program.find(m, 5);
        if (coordinate == null)
        {
            Console.WriteLine("Congratulations! Secret message: " + SecretPassword("OWCEPMOZMUGYTZNRIVABHGLMEKUOIVUQTSAH"));
        }
        else
        {
            Console.WriteLine("Fail, try again!");
        }
        Program.PressEnterToContinue();
    }

    // Allows user to see updates every turn.
    public static void PlayManualUnlimited(int[,] m)
    {
        String userInput = "";
        // Player location
        int[] coordinate = Program.FindPlayer(m);
        int r = coordinate[0];
        int c = coordinate[1];
        // This continues to run until you reach the finish line.
        // 6 is the code for the finish line, and when you reach it, you'll overwrite it.
        // So keep running the code until the 6 is off the board.
        while (Program.find(m, 5) != null)
        {
            Program.ClearScreen();
            Program.PrintMap(m);
            Console.WriteLine("You are the arrow.");
            Console.WriteLine("Type in L, R, and F to navigate to the finish.");
            Console.WriteLine("L = turn left, R = turn right, F = move forward.");
            Console.WriteLine("Type in 1 letter at a time and press enter.");
            Console.Write("> ");
            // Uppercase the user input to make the checking more uniform. Check equsl F instead of f or F.
            userInput = Console.ReadLine().ToUpper();
            // This updates the map with a single action
            Program.UpdateMap(m, userInput);
        }
        // Just print 1 more time before exiting. Otherwise, the last view
        // would be of you just before the goal.
        Program.ClearScreen();
        Program.PrintMap(m);
    }
    // Allows for multiple commands at once, but only accepts 1 input
    public static void PlayManualOnce(int[,] m)
    {
        String userInput = "";
        // Player location
        int[] coordinate = Program.FindPlayer(m);
        int r = coordinate[0];
        int c = coordinate[1];
        // This continues to run until you reach the finish line.
        // 6 is the code for the finish line, and when you reach it, you'll overwrite it.
        // So keep running the code until the 6 is off the board.
        Program.ClearScreen();
        Program.PrintMap(m);
        Console.WriteLine("You are the arrow.");
        Console.WriteLine("Type in L, R, and F to navigate to the finish.");
        Console.WriteLine("L = turn left, R = turn right, F = move forward.");
        Console.WriteLine("Type in ALL actions at once then press enter.");
        Console.Write("> ");
        // Uppercase the user input to make the checking more uniform. Check equsl F instead of f or F.
        userInput = Console.ReadLine().ToUpper();
        Program.ExecuteActions(m, userInput);
    }
    // Performs a sequence of actions represented as a String, ex, "RRLFFLLF"
    public static void ExecuteActions(int[,] m, String actions)
    {
        while (string.CompareOrdinal(actions, "") != 0)
        {
            // UpdateMap based on first letter of userInput
            Program.UpdateMap(m, actions.Substring(0, 1 - 0));
            // Chop off the first letter of userInput.
            actions = actions.Substring(1);
            Program.Pause();
            Program.ClearScreen();
            Program.PrintMap(m);
        }
    }
    public static void UpdateMap(int[,] m, String action)
    {
        // Checks valid inputs L,R,F. Ignores anything else.
        if (string.CompareOrdinal(action, "L") == 0)
        {
            // User had typed in L
            Program.TurnLeft(m);
        }
        else if (string.CompareOrdinal(action, "R") == 0)
        {
            Program.TurnRight(m);
        }
        else if (string.CompareOrdinal(action, "F") == 0 && Program.CanMoveF(m))
        {
            Program.MoveForward(m);
        }
    }
    public static void TurnLeft(int[,] m)
    {
        int[] coordinate = Program.FindPlayer(m);
        int r = coordinate[0];
        int c = coordinate[1];
        m[r, c] = (m[r, c] + 2) % 4 + 1;
    }
    public static void TurnRight(int[,] m)
    {
        int[] coordinate = Program.FindPlayer(m);
        int r = coordinate[0];
        int c = coordinate[1];
        m[r, c] = m[r, c] % 4 + 1;
    }
    public static void MoveForward(int[,] m)
    {
        int[] coordinate = Program.FindPlayer(m);
        int r = coordinate[0];
        int c = coordinate[1];
        if (Program.CanMoveF(m))
        {
            if (m[r, c] == 1)
            {
                m[r - 1, c] = 1;
            }
            else if (m[r, c] == 2)
            {
                m[r, c + 1] = 2;
            }
            else if (m[r, c] == 3)
            {
                m[r + 1, c] = 3;
            }
            else if (m[r, c] == 4)
            {
                m[r, c - 1] = 4;
            }
            m[r, c] = 0;
        }
    }
    public static void PressEnterToContinue()
    {
        Console.WriteLine("press enter to continue");
        Console.ReadLine();
    }
    public static void ClearScreen()
    {
        Console.Clear();
    }
    public static void Pause()
    {
        try
        {
            Thread.Sleep(500);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
    public static int[,] CreateMap(int rowSize, int colSize)
    {
        if (rowSize <= 0 || colSize <= 0)
        {
            return null;
        }
        int r = 0;
        int c = 0;
        int[,] m = new int[2 * rowSize + 1, 2 * colSize + 1];
        Program.CreateMapHelper(m, 0, 2 * rowSize, 0, 2 * colSize);
        // Randomly spawn player
        int[] coordinate = Program.find(m, 6);
        r = coordinate[0];
        c = coordinate[1];
        while (m[r, c] != 0)
        {
            r = (int)(MathRandom() * rowSize);
            c = (int)(MathRandom() * colSize);
        }
        m[r, c] = 1;
        // Randomly spawn goal
        while (m[r, c] != 0)
        {
            r = (int)(MathRandom() * rowSize);
            c = (int)(MathRandom() * colSize);
        }
        m[r, c] = 5;
        return m;
    }
    public static int GetRandomObstacle()
    {
        return 6 + (int)(MathRandom() * 5);
    }
    public static void CreateMapHelper(int[,] m, int rowMin, int rowMax, int colMin, int colMax)
    {
        // This is the recursive division algorithm as described here:
        // https://en.wikipedia.org/wiki/Maze_generation_algorithm
        // Base case: When the region becomes too small, stop.
        bool mustDivideRows = rowMax - rowMin >= 2;
        bool mustDivideCols = colMax - colMin >= 2;
        if (!mustDivideRows || !mustDivideCols)
        {
            return;
        }
        // Pick a random row and column, leaving space for travelling on the outer edges and between walls.
        // (rowMax - rowMin - 1) / 2: this is to calculate the number of walls in this region.
        // The following + rowMin + 1 is to align the random number with where walls should go.
        // randomRow, randomCol initialized to -1, and will remain -1 if we are not creating corresponding row/wall.
        int randomRow = -1;
        int randomCol = -1;
        randomRow = (int)(MathRandom() * (rowMax - rowMin - 1) / 2) * 2 + rowMin + 1;
        randomCol = (int)(MathRandom() * (colMax - colMin - 1) / 2) * 2 + colMin + 1;
        // Draw the line of walls, creating up to 4 quadrants.
        // Includes checks to see if you must divide rows.
        for (int i = colMin; i <= colMax; i++)
        {
            m[randomRow, i] = 6;
        }
        // 6 is obstacle / cactus.
        for (int i = rowMin; i <= rowMax; i++)
        {
            m[i, randomCol] = 6;
        }
        // 6 is obstacle / cactus.
        // Create a random hole on the created row
        // On a pathway, not a wall.
        // Loop until your random spot is not on the intersection of row and col.
        int randomRowHole = randomCol;
        int randomColHole = randomRow;
        while (randomRowHole == randomCol)
        {
            // below is +2?
            randomRowHole = (int)(MathRandom() * ((int)((colMax - colMin) / 2) + 1)) * 2 + colMin;
        }
        while (randomColHole == randomRow)
        {
            randomColHole = (int)(MathRandom() * ((int)((rowMax - rowMin) / 2) + 1)) * 2 + rowMin;
        }
        m[randomRow, randomRowHole] = 0;
        // 0 = empty space
        m[randomColHole, randomCol] = 0;
        // Flip a coin to decide if the 3rd hole goes on the row or column.
        bool isHeads = MathRandom() > 0.5;
        // This will be true or false.
        bool isMinSide = false;
        int newHoleCoordinate = 0;
        if (isHeads)
        {
            // Put the extra hole on the row.
            // Determine if the existing randomColHole is on the min or max side of the subdivision.
            isMinSide = randomRowHole < randomCol;
            if (isMinSide)
            {
                // then put the new hole on the max side.
                newHoleCoordinate = (int)(MathRandom() * (colMax - randomCol + 1) / 2) * 2 + randomCol + 1;
            }
            else
            {
                // then put the hole on the min side.
                newHoleCoordinate = (int)(MathRandom() * (randomCol - colMin - 1) / 2) * 2 + colMin;
            }
            m[randomRow, newHoleCoordinate] = 0;
        }
        else
        {
            // Put the extra hole on the col.
            // Determine if the existing randomRowHole is on the min or max side of the subdivision.
            isMinSide = randomColHole < randomRow;
            if (isMinSide)
            {
                // then put the new hole on the max side.
                newHoleCoordinate = (int)(MathRandom() * (rowMax - randomRow + 1) / 2) * 2 + randomRow + 1;
            }
            else
            {
                // then put the hole on the min side.
                newHoleCoordinate = (int)(MathRandom() * (randomRow - rowMin - 1) / 2) * 2 + rowMin;
            }
            m[newHoleCoordinate, randomCol] = 0;
        }
        // Recursive calls to inner regions.
        Program.CreateMapHelper(m, rowMin, randomRow - 1, colMin, randomCol - 1);
        // UL
        Program.CreateMapHelper(m, rowMin, randomRow - 1, randomCol + 1, colMax);
        // UR
        Program.CreateMapHelper(m, randomRow + 1, rowMax, colMin, randomCol - 1);
        // BL
        Program.CreateMapHelper(m, randomRow + 1, rowMax, randomCol + 1, colMax);
    }
    public static String getSymbol(int value)
    {
        // We represent facing up as value 1, facing right as 2, down as 3, left as 4.
        if (value == 0)
        {
            return "__";
        }
        // Face Up
        if (value == 1)
        {
            return "👆";
        }
        // Face Right
        if (value == 2)
        {
            return "👉";
        }
        // Face Down
        if (value == 3)
        {
            return "👇";
        }
        // Face Left
        if (value == 4)
        {
            return "👈";
        }
        if (value == 5)
        {
            return "🏁";
        }
        if (value == 6)
        {
            return "🌵";
        }
        if (value == 7)
        {
            return "🐒";
        }
        if (value == 8)
        {
            return "🐍";
        }
        if (value == 9)
        {
            return "🐚";
        }
        if (value == 10)
        {
            return "🌷";
        }
        return "  ";
    }
    // end getSymbol
    public static void PrintMap(int[,] m)
    {
        Console.WriteLine("Maze Game!!!");
        Console.WriteLine(Program.mapToString(m));
    }
    public static String mapToString(int[,] m)
    {
        String rv = "";
        for (int r = 0; r < m.GetLength(0); r++)
        {
            for (int c = 0; c < m.GetLength(1); c++)
            {
                rv += "  " + Program.getSymbol(m[r, c]);
            }
            rv += "\n";
        }
        return rv;
    }
    // end mapToString()
    public static int[] find(int[,] m, int value)
    {
        // Ex, find( {{0,0,3},{3,3,2},{1,3,0}} , 1) => {2,0} the coordinates row2, col0.
        // noCoordinate => null;
        int[] coordinate = new int[2];
        for (int r = 0; r < m.GetLength(0); r++)
        {
            for (int c = 0; c < m.GetLength(1); c++)
            {
                if (m[r, c] == value)
                {
                    coordinate[0] = r;
                    coordinate[1] = c;
                    return coordinate;
                }
            }
        }
        return null;
    }
    // end find()
    // Finds player on the map. Player will have value 1,2,3, or 4.
    public static int[] FindPlayer(int[,] m)
    {
        int[] coordinate = new int[2];
        for (int r = 0; r < m.GetLength(0); r++)
        {
            for (int c = 0; c < m.GetLength(1); c++)
            {
                if (m[r, c] >= 1 && m[r, c] <= 4)
                {
                    coordinate[0] = r;
                    coordinate[1] = c;
                    return coordinate;
                }
            }
        }
        return null;
    }
    public static bool CanMoveF(int[,] m)
    {
        // This function checks to see if player can walk forward.
        // Find the player
        int[] myCoordinates = Program.FindPlayer(m);
        int r = myCoordinates[0];
        int c = myCoordinates[1];
        // Player facing up
        // You can have separate if statements for each direction.
        //      The following is for facing up:
        //      if(m[r][c] == 1 && canGoN(m))
        //        return true;
        // Or you can just combine all directions:
        return m[r, c] == 1 && Program.canGoN(m) || m[r, c] == 2 && Program.canGoE(m) || m[r, c] == 3 && Program.canGoS(m) || m[r, c] == 4 && Program.canGoW(m);
    }
    public static bool canGoN(int[,] m)
    {
        // Find the player
        int[] myCoordinates = Program.FindPlayer(m);
        int r = myCoordinates[0];
        int c = myCoordinates[1];
        // Checks if the spot below is empty or finish.
        //  if(r-1 >= 0 && (m[r-1][c] == 0 || m[r-1][c] == 2)){
        //         return true;
        //       return false;
        // The previous 3 lines can be replaced with:
        return r >= 1 && (m[r - 1, c] == 0 || m[r - 1, c] == 5);
    }
    public static String minPath(int[,] m)
    {
        // Congratulations hacker, you found the bonus challenge.
        // Bonus Challenge: Find a minimal path to the finish.
        // Your answer should look something like "RRFFFLFRFFLFFF" using our standard LRF
        // or more simply "DDDRDDRRR" for move up down left right.
        // Reward: First one to complete this and submit to teacher gets a gold star.
        // Not real gold.
        String path = "";
        return path;
    }
    public static bool canGoS(int[,] m)
    {
        int[] myCoordinates = Program.FindPlayer(m);
        int r = myCoordinates[0];
        int c = myCoordinates[1];
        return r < m.Length - 1 && (m[r + 1, c] == 0 || m[r + 1, c] == 5);
    }
    public static bool canGoE(int[,] m)
    {
        int[] myCoordinates = Program.FindPlayer(m);
        int r = myCoordinates[0];
        int c = myCoordinates[1];
        return c < m.GetLength(1) - 1 && (m[r, c + 1] == 0 || m[r, c + 1] == 5);
    }
    public static bool canGoW(int[,] m)
    {
        int[] myCoordinates = Program.FindPlayer(m);
        int r = myCoordinates[0];
        int c = myCoordinates[1];
        return c >= 1 && (m[r, c - 1] == 0 || m[r, c - 1] == 5);
    }
    public static double MathRandom()
    {
        return (new Random()).NextDouble();
    }
    public static int MathRandomInt(int size)
    {
        return (int)((new Random()).NextDouble() * size);
    }
    public static String SecretPassword(String s)
    {
        if (s.Length < 4)
            return "";
        String ans = "", ss = s.Substring(5, 1);
        int key = s.Substring(6).IndexOf(ss) + 1;
        //Console.WriteLine(ss + " " + key);
        if (key <= 0)
            return "";
        for (int i = 6; i < s.Length; i += key)
            ans += s.Substring(i, 1);
        return ans;
    }
    public static String CreatePassword(String s)
    {
        String ans = "";
        int d = MathRandomInt(5) + 3;
        char key = RandomLetter();
        for (int i = 0; i < 5; i++)
            ans += RandomLetter();
        ans += key + s.Substring(0, 1);
        for (int i = 0; i < d - 2; i++)
            ans += RandomLetter();
        ans += key + s.Substring(1, 1);
        for (int i = 2; i < s.Length; i++)
        {
            for (int j = 0; j < d - 1; j++)
                ans += RandomLetter();
            ans += s.Substring(i, 1);
        }
        for (int i = 0; i < d - 1; i++)
            ans += RandomLetter();
        if (SecretPassword(ans).Equals(s))
            return ans;
        return CreatePassword(s);
    }
    public static char RandomLetter()
    {
        return (char)('A' + MathRandomInt(26));
    }
}