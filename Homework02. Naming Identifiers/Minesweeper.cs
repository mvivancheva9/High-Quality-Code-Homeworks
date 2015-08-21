namespace Minesweeper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Minessweeper
    {
        public static void Main(string[] arguments)
        {
            string command = string.Empty;
            char[,] playingField = CreatePlayingField();
            char[,] mines = PutMines();
            int pointsCounter = 0;
            bool isBoom = false;
            List<Points> winners = new List<Points>(6);
            int row = 0;
            int column = 0;
            bool isStart = true;
            const int FieldsWithoutMines = 35;
            bool isWon = false;

            do
            {
                if (isStart)
                {
                    Console.WriteLine("Let's play some 'Minesweepers' Take a shot and try to find the fields without mines." +
                    " Command 'top' shows the highscore board, 'restart' starts an new game, 'exit' exits the game and Bye, bye!");
                    PrintPlayinfField(playingField);
                    isStart = false;
                }

                Console.Write("Please, enter row and column: ");
                command = Console.ReadLine().Trim();
                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                    int.TryParse(command[2].ToString(), out column) &&
                        row <= playingField.GetLength(0) && column <= playingField.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        HighScoresBoard(winners);
                        break;
                    case "restart":
                        playingField = CreatePlayingField();
                        mines = PutBombs();
                        PrintPlayinfField(playingField);
                        isBoom = false;
                        isStart = false;
                        break;
                    case "exit":
                        Console.WriteLine("Bye, Bye, Bye!");
                        break;
                    case "turn":
                        if (mines[row, column] != '*')
                        {
                            if (mines[row, column] == '-')
                            {
                                ItIsYourTurn(playingField, mines, row, column);

                                pointsCounter++;
                            }

                            if (FieldsWithoutMines == pointsCounter)
                            {
                                isWon = true;
                            }
                            else
                            {
                                PrintPlayinfField(playingField);
                            }
                        }
                        else
                        {
                            isBoom = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nInvalid Command!\n");
                        break;
                }

                if (isBoom)
                {
                    PrintPlayinfField(mines);
                    Console.Write("\nGame Over. You won {0} points." + "Please enter your nickname: ", pointsCounter);
                    string nickname = Console.ReadLine();
                    Points playersPoints = new Points(nickname, pointsCounter);
                    if (winners.Count < 5)
                    {
                        winners.Add(playersPoints);
                    }
                    else
                    {
                        for (int winnersIterator = 0; winnersIterator < winners.Count; winnersIterator++)
                        {
                            if (winners[winnersIterator].PointsWon < playersPoints.PointsWon)
                            {
                                winners.Insert(winnersIterator, playersPoints);
                                winners.RemoveAt(winners.Count - 1);
                                break;
                            }
                        }
                    }

                    winners.Sort((Points r1, Points r2) => r2.PlayerName.CompareTo(r1.PlayerName));
                    winners.Sort((Points r1, Points r2) => r2.PointsWon.CompareTo(r1.PointsWon));
                    HighScoresBoard(winners);

                    playingField = CreatePlayingField();
                    mines = PutBombs();
                    pointsCounter = 0;

                    isBoom = false;
                    isStart = true;
                }

                if (isWon)
                {
                    Console.WriteLine("\nGood Job! You succeded in opening all the fields without stepping on a bomb even once");
                    PrintPlayinfField(mines);
                    Console.WriteLine("Please, enter your name: ");
                    string nickName = Console.ReadLine();
                    Points playersPoints = new Points(nickName, pointsCounter);
                    winners.Add(playersPoints);
                    HighScoresBoard(winners);
                    playingField = CreatePlayingField();
                    mines = PutBombs();
                    pointsCounter = 0;
                    isWon = false;
                    isStart = true;
                }
            }
            while (command != "exit");
            Console.WriteLine("Made in Bulgaria");
            Console.WriteLine("Come On.");
            Console.Read();
        }

        private static char[,] PutMines()
        {
            throw new NotImplementedException();
        }

        private static void HighScoresBoard(List<Points> playersPoints)
        {
            Console.WriteLine("\nPoints: ");
            if (playersPoints.Count > 0)
            {
                for (int plyersPointsIterator = 0; plyersPointsIterator < playersPoints.Count; plyersPointsIterator++)
                {
                    Console.WriteLine("{0}. {1} --> {2} field boxes", plyersPointsIterator + 1, playersPoints[plyersPointsIterator].PlayerName, playersPoints[plyersPointsIterator].PointsWon);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Empty Chart!\n");
            }
        }

        private static void ItIsYourTurn(char[,] playingField, char[,] mines, int row, int column)
        {
            char minesCounter = CountMines(mines, row, column);
            mines[row, column] = minesCounter;
            playingField[row, column] = minesCounter;
        }

        private static void PrintPlayinfField(char[,] board)
        {
            int rows = board.GetLength(0);
            int columns = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int row = 0; row < rows; row++)
            {
                Console.Write("{0} | ", row);
                for (int column = 0; column < columns; column++)
                {
                    Console.Write(string.Format("{0} ", board[row, column]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreatePlayingField()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];
            for (int row = 0; row < boardRows; row++)
            {
                for (int column = 0; column < boardColumns; column++)
                {
                    board[row, column] = '?';
                }
            }

            return board;
        }

        private static char[,] PutBombs()
        {
            int rows = 5;
            int columns = 10;
            char[,] playingField = new char[rows, columns];

            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < columns; column++)
                {
                    playingField[row, column] = '-';
                }
            }

            List<int> mines = new List<int>();
            while (mines.Count < 15)
            {
                Random random = new Random();
                int numberAtRandom = random.Next(50);
                if (!mines.Contains(numberAtRandom))
                {
                    mines.Add(numberAtRandom);
                }
            }

            foreach (int mine in mines)
            {
                int column = mine / columns;
                int row = mine % columns;
                if (row == 0 && mine != 0)
                {
                    column--;
                    row = columns;
                }
                else
                {
                    row++;
                }

                playingField[column, row - 1] = '*';
            }

            return playingField;
        }

        private static void CalculateFieldPoints(char[,] playingField)
        {
            int rows = playingField.GetLength(0);
            int columns = playingField.GetLength(1);

            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < columns; column++)
                {
                    if (playingField[row, column] != '*')
                    {
                        char minesCount = CountMines(playingField, row, column);
                        playingField[row, column] = minesCount;
                    }
                }
            }
        }

        private static char CountMines(char[,] plyingField, int row, int column)
        {
            int minesCounter = 0;
            int rows = plyingField.GetLength(0);
            int columns = plyingField.GetLength(1);

            if (row - 1 >= 0)
            {
                if (plyingField[row - 1, column] == '*')
                {
                    minesCounter++;
                }
            }

            if (row + 1 < rows)
            {
                if (plyingField[row + 1, column] == '*')
                {
                    minesCounter++;
                }
            }

            if (column - 1 >= 0)
            {
                if (plyingField[row, column - 1] == '*')
                {
                    minesCounter++;
                }
            }

            if (column + 1 < columns)
            {
                if (plyingField[row, column + 1] == '*')
                {
                    minesCounter++;
                }
            }

            if ((row - 1 >= 0) && (column - 1 >= 0))
            {
                if (plyingField[row - 1, column - 1] == '*')
                {
                    minesCounter++;
                }
            }

            if ((row - 1 >= 0) && (column + 1 < columns))
            {
                if (plyingField[row - 1, column + 1] == '*')
                {
                    minesCounter++;
                }
            }

            if ((row + 1 < rows) && (column - 1 >= 0))
            {
                if (plyingField[row + 1, column - 1] == '*')
                {
                    minesCounter++;
                }
            }

            if ((row + 1 < rows) && (column + 1 < columns))
            {
                if (plyingField[row + 1, column + 1] == '*')
                {
                    minesCounter++;
                }
            }

            return char.Parse(minesCounter.ToString());
        }
    }
}
