/* Карта
 * 1 2 3
 * 4 5 6
 * 7 8 9
 */

byte map_1 = 0;
byte map_2 = 0;
byte map_3 = 0;
byte map_4 = 0;
byte map_5 = 0;
byte map_6 = 0;
byte map_7 = 0;
byte map_8 = 0;
byte map_9 = 0;

// Ходы //
// 1 = х | 2 = o
byte move = 1;
byte new_move = 0;

bool game_end = false;

// Функции //
void resetvars()
{
    map_1 = 0;
    map_2 = 0;
    map_3 = 0;
    map_4 = 0;
    map_5 = 0;
    map_6 = 0;
    map_7 = 0;
    map_8 = 0;
    map_9 = 0;

    // Ходы //
    // 1 = х | 2 = o
    move = 1;
    new_move = 0;
}

void PrintMap() // Отрисовка карты
{
    Console.Clear();
    Console.WriteLine("------------------");

    if (map_1 == 0)
    {
        Console.Write("1 ");
    }
    if (map_1 == 1)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("x ");
    }
    if (map_1 == 2)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("o ");
    }
    Console.ResetColor();

    //

    if (map_2 == 0)
    {
        Console.Write("2 ");
    }
    if (map_2 == 1)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("x ");
    }
    if (map_2 == 2)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("o ");
    }
    Console.ResetColor();

    //

    if (map_3 == 0)
    {
        Console.WriteLine("3");
    }
    if (map_3 == 1)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("x");
    }
    if (map_3 == 2)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("o");
    }
    Console.ResetColor();

    //

    if (map_4 == 0)
    {
        Console.Write("4 ");
    }
    if (map_4 == 1)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("x ");
    }
    if (map_4 == 2)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("o ");
    }
    Console.ResetColor();

    //

    if (map_5 == 0)
    {
        Console.Write("5 ");
    }
    if (map_5 == 1)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("x ");
    }
    if (map_5 == 2)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("o ");
    }
    Console.ResetColor();

    //

    if (map_6 == 0)
    {
        Console.WriteLine("6");
    }
    if (map_6 == 1)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("x");
    }
    if (map_6 == 2)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("o");
    }
    Console.ResetColor();

    //

    if (map_7 == 0)
    {
        Console.Write("7 ");
    }
    if (map_7 == 1)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("x ");
    }
    if (map_7 == 2)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("o ");
    }
    Console.ResetColor();

    //

    if (map_8 == 0)
    {
        Console.Write("8 ");
    }
    if (map_8 == 1)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("x ");
    }
    if (map_8 == 2)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("o ");
    }
    Console.ResetColor();

    //

    if (map_9 == 0)
    {
        Console.WriteLine("9");
    }
    if (map_9 == 1)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("x");
    }
    if (map_9 == 2)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("o");
    }
    Console.ResetColor();
}

void NewMove() // Логика нового хода
{
    // 1 = x | 2 = o
    switch (new_move)
    {
        case 1:
            if (map_1 == 0)
            {
                if (move == 1) map_1 = 1;
                else if (move == 2) map_1 = 2;
            }
            else NewMoveChanger();
            break;

        case 2:
            if (map_2 == 0)
            {
                if (move == 1) map_2 = 1;
                else if (move == 2) map_2 = 2;
            }
            else NewMoveChanger();
            break;

        case 3:
            if (map_3 == 0)
            {
                if (move == 1) map_3 = 1;
                else if (move == 2) map_3 = 2;
            }
            else NewMoveChanger();
            break;

        case 4:
            if (map_4 == 0)
            {
                if (move == 1) map_4 = 1;
                else if (move == 2) map_4 = 2;
            }
            else NewMoveChanger();
            break;

        case 5:
            if (map_5 == 0)
            {
                if (move == 1) map_5 = 1;
                else if (move == 2) map_5 = 2;
            }
            else NewMoveChanger();
            break;

        case 6:
            if (map_6 == 0)
            {
                if (move == 1) map_6 = 1;
                else if (move == 2) map_6 = 2;
            }
            else NewMoveChanger();
            break;

        case 7:
            if (map_7 == 0)
            {
                if (move == 1) map_7 = 1;
                else if (move == 2) map_7 = 2;
            }
            else NewMoveChanger();
            break;

        case 8:
            if (map_8 == 0)
            {
                if (move == 1) map_8 = 1;
                else if (move == 2) map_8 = 2;
            }
            else NewMoveChanger();
            break;

        case 9:
            if (map_9 == 0)
            {
                if (move == 1) map_9 = 1;
                else if (move == 2) map_9 = 2;
            }
            else NewMoveChanger();
            break;

        default:
        {
            NewMoveChanger();
            break;
        }
    }
}
void PrintNewMoveText() // Написать текст о новом ходе
{
    // 1 = x | 2 = o
    if (move == 1)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("O move");
    }
    else if (move == 2)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("X move");
    }
    Console.ResetColor();
    NewMoveChanger();
    Console.WriteLine("------------------");
    CheckEnd();
}
void NewMoveChanger() // Изменить игрока в след. ходе
{
    // 1 = x | 2 = o
    if (move == 1) move = 2;
    else if (move == 2) move = 1;
}
void CheckEnd() // Проверка победы
{
    /* Карта
    * 1 2 3
    * 4 5 6
    * 7 8 9
    */
    // 1 = x | 2 = o

    if (map_1 == 1 && map_2 == 1 && map_3 == 1)
    {
        Console.WriteLine("X wins\n------------------");
        game_end = true;
    }
    else if (map_1 == 2 && map_2 == 2 && map_3 == 2)
    {
        Console.WriteLine("O wins\n------------------");
        game_end = true;
    }

    else if (map_4 == 1 && map_5 == 1 && map_6 == 1)
    {
        Console.WriteLine("X wins\n------------------");
        game_end = true;
    }
    else if (map_4 == 2 && map_5 == 2 && map_6 == 2)
    {
        Console.WriteLine("O wins\n------------------"); 
        game_end = true;
    }

    else if(map_7 == 1 && map_8 == 1 && map_9 == 1)
    {
        Console.WriteLine("X wins\n------------------");
        game_end = true;
    }
    else if(map_7 == 2 && map_8 == 2 && map_9 == 2)
    {
        Console.WriteLine("O wins\n------------------");
        game_end = true;
    }

    // // // // // // // // // // // // // // // // // // // // // //

    else if(map_1 == 1 && map_4 == 1 && map_7 == 1)
    {
        Console.WriteLine("X wins\n------------------");
        game_end = true;
    }
    else if(map_1 == 2 && map_4 == 2 && map_7 == 2)
    {
        Console.WriteLine("O wins\n------------------");
        game_end = true;
    }

    else if(map_2 == 1 && map_5 == 1 && map_8 == 1)
    {
        Console.WriteLine("X wins\n------------------");
        game_end = true;
    }
    else if(map_2 == 2 && map_5 == 2 && map_8 == 2)
    {
        Console.WriteLine("O wins\n------------------");
        game_end = true;
    }

    else if(map_3 == 1 && map_6 == 1 && map_9 == 1)
    {
        Console.WriteLine("X wins\n------------------");
        game_end = true;
    }
    else if(map_3 == 2 && map_6 == 2 && map_9 == 2)
    {
        Console.WriteLine("O wins\n------------------");
        game_end = true;
    }

    // // // // // // // // // // // // // // // // // // // // // //

    else if(map_1 == 1 && map_5 == 1 && map_9 == 1)
    {
        Console.WriteLine("X wins\n------------------");
        game_end = true;
    }
    else if(map_1 == 2 && map_5 == 2 && map_9 == 2)
    {
        Console.WriteLine("O wins\n------------------");
        game_end = true;
    }

    else if(map_3 == 1 && map_5 == 1 && map_7 == 1)
    {
        Console.WriteLine("X wins\n------------------");
        game_end = true;
    }
    else if (map_3 == 2 && map_5 == 2 && map_7 == 2)
    {
        Console.WriteLine("O wins\n------------------");
        game_end = true;
    }

    // // // // // // // // // // // // // // // // // // // // // //

    else if(map_1 == 1 | map_1 == 2 && map_2 == 1 | map_2 == 2 && map_3 == 1 | map_3 == 2 && map_4 == 1 | map_4 == 2 && map_5 == 1 | map_5 == 2 && map_6 == 1 | map_6 == 2 && map_7 == 1 | map_7 == 2 && map_8 == 1 | map_8 == 2 && map_9 == 1 | map_9 == 2)
    {
        Console.WriteLine("Draw\n------------------");
        game_end = true;
    }
}

// Игра
while (true)
{
    while (game_end == false)
    {
        PrintMap();

        PrintNewMoveText();
        try
        {
            new_move = Convert.ToByte(Console.ReadLine());
        }
        catch (System.FormatException)
        {
            NewMoveChanger();
            continue;
        }

        NewMove();
    }
    if (game_end == true) Console.WriteLine("Play again?");
    Console.ReadLine();
    game_end = false;
    resetvars();
}
