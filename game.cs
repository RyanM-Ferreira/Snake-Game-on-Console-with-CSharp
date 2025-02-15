class InGame
{
  public static void GameFunction()
  {
    Console.Clear();

    int mapHeight = 20;
    int mapWidth = 35;

    int[] PosX = new int[mapHeight * mapWidth];
    int[] PosY = new int[mapHeight * mapWidth];

    PosX[0] = mapWidth / 2;
    PosY[0] = mapHeight / 2;

    int directionX = 0;
    int directionY = 0;

    int fruitX = 0;
    int fruitY = 0;

    int snakeLength = 3;
    int score = 0;

    bool isGameOver = false;
    bool Won = false;

    int runDelay = 150;

    Console.CursorVisible = false;
    spawnFruit(ref fruitX, ref fruitY, mapWidth, mapHeight);

    Mesh(runDelay, PosX, PosY, ref directionX, ref directionY, mapHeight, mapWidth, ref snakeLength, ref fruitX, ref fruitY, ref isGameOver, ref Won, ref score);
  }

  static void Mesh(int runDelay, int[] PosX, int[] PosY, ref int directionX, ref int directionY, int mapHeight, int mapWidth, ref int snakeLength, ref int fruitX, ref int fruitY, ref bool isGameOver, ref bool Won, ref int score)
  {
    while (true)
    {
      Console.Clear();
      string drawGame = "";

      // Movimentação da Cobra.
      if (Console.KeyAvailable)
      {
        ConsoleKeyInfo pressedKey = Console.ReadKey(true);

        if (pressedKey.Key == ConsoleKey.UpArrow && directionY != 1)
        {
          directionX = 0;
          directionY = -1;
        }
        else if (pressedKey.Key == ConsoleKey.DownArrow && directionY != -1)
        {
          directionX = 0;
          directionY = 1;
        }
        else if (pressedKey.Key == ConsoleKey.LeftArrow && directionX != 1)
        {
          directionX = -1;
          directionY = 0;
        }
        else if (pressedKey.Key == ConsoleKey.RightArrow && directionX != -1)
        {
          directionX = 1;
          directionY = 0;
        }
      }

      // Atualza a posiç~ao dos segmentos da cobra, trocando o atual pela posição do segmento anterior.
      for (int i = snakeLength; i > 0; i--)
      {
        PosX[i] = PosX[i - 1];
        PosY[i] = PosY[i - 1];
      }

      // Atualiza a posição da cabeça da cobra.
      PosX[0] += directionX;
      PosY[0] += directionY;

      // Verifica se a cobra comeu a fruta.
      if (PosX[0] == fruitX && PosY[0] == fruitY)
      {
        score++;
        snakeLength++;

        for (int i = 0; i < snakeLength; i++)
        {
          while (PosX[i] == fruitX && PosY[i] == fruitY)
          {
            spawnFruit(ref fruitX, ref fruitY, mapWidth, mapHeight);
          }
        }
      }

      // Verifica se a cobra colidiu com ela mesma.
      for (int i = 3; i < snakeLength; i++)
      {
        if (PosX[0] == PosX[i] && PosY[0] == PosY[i])
        {
          isGameOver = true;
        }
      }

      // Verifica se a cobra colidiu com as paredes.
      if (PosX[0] < 0 || PosX[0] > mapWidth || PosY[0] < 0 || PosY[0] > mapHeight)
      {
        isGameOver = true;
      }

      // Verifica se a vit´oria ocorrreu.
      if (snakeLength == mapWidth * mapHeight)
      {
        Won = true;
      }

      // Autoexplicativo
      if (isGameOver || Won)
      {
        Result.CheckGameResult(isGameOver, Won);
        break;
      }

      // Gera a malha onde o jogo será renderizado.
      for (int y = -1; y <= mapHeight + 1; y++)
      {
        for (int x = -1; x <= mapWidth + 1; x++)
        {
          if (x == -1 || x == mapWidth + 1 || y == -1 || y == mapHeight + 1)
          {
            drawGame += "#";
          }
          else if (PosX[0] == x && PosY[0] == y)
          {
            drawGame += "O";
          }
          else if (fruitX == x && fruitY == y)
          {
            drawGame += "$";
          }
          else
          {
            bool isBody = false;
            for (int i = 1; i < snakeLength; i++)
            {
              if (PosX[i] == x && PosY[i] == y)
              {
                drawGame += "o";
                isBody = true;
                break;
              }
            }
            if (!isBody)
            {
              drawGame += " ";
            }
          }
        }
        drawGame += "\n";
      }

      // Menu de Debug.
      Console.WriteLine($"Your Score: {score}.\n");
      Console.WriteLine(drawGame);
      Console.WriteLine($"Debug Menu:\nPosX: {PosX[0]}; PosY: {PosY[0]}; Snake Size: {snakeLength}.\nFruitX: {fruitX}; FruitY: {fruitY}\n\nGame Over? {isGameOver}.\n\nMap Width: {mapWidth}; Map Height: {mapHeight}; Map Size: {mapWidth * mapHeight}.");
      Thread.Sleep(runDelay);
    }
  }

  static void spawnFruit(ref int fruitX, ref int fruitY, int mapWidth, int mapHeight)
  {
    Random random = new Random();
    fruitX = random.Next(0, mapWidth);
    fruitY = random.Next(0, mapHeight);
  }
}