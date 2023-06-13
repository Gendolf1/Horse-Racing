using System;
using System.Threading;

int score = 10;
int choose = 0;
byte pos1x = 0;
byte pos2x = 0;
byte pos3x = 0;
sbyte winner = -1;
int way = 30;
Random rand = new Random();
int rnd;
bool flag = true;
while(score>0)
{
    Console.Clear();
    Console.WriteLine("You score: " + score);
    Console.Write("Your choose (1-3): ");
    choose = int.Parse(Console.ReadLine());
    for (int x = 0; x < way; x++)
    {
        Console.SetCursorPosition(x, 3);
        Console.Write("_");
        Console.SetCursorPosition(x, 5);
        Console.Write("_");
        Console.SetCursorPosition(x, 7);
        Console.Write("_");
    }
    while (flag)
    {
        Console.SetCursorPosition(pos1x, 3);
        Console.Write("_");
        Console.SetCursorPosition(pos2x, 5);
        Console.Write("_");
        Console.SetCursorPosition(pos3x, 7);
        Console.Write("_");

        rnd = rand.Next(1, 4);

        if (rnd == 1 && pos1x != way)
        {
            pos1x++;
        }
        if (rnd == 2 && pos2x != way)
        {
            pos2x++;
        }
        if (rnd == 3 && pos3x != way)
        {
            pos3x++;
        }

        if (rnd == 1 && pos1x != way)
        {
            if (++pos1x == way)
            {
                winner = 1;
                flag = false;
            }
        }
        if (rnd == 2 && pos2x != way)
        {
            if (++pos2x == way)
            {
                winner = 2;
                flag = false;
            }
        }
        if (rnd == 3 && pos3x != way)
        {
            if (++pos3x == way)
            {
                winner = 3;
                flag = false;
            }
        }
        Console.SetCursorPosition(pos1x, 3);
        Console.Write("9");
        Console.SetCursorPosition(pos2x, 5);
        Console.Write("9");
        Console.SetCursorPosition(pos3x, 7);
        Console.Write("9");
        Thread.Sleep(40);
    }
    Console.SetCursorPosition(0, 9);
    Console.Write(winner + " horse win!");
    if(choose == winner)
    {
        score += 2;
        Console.SetCursorPosition(0, 10);
        Console.WriteLine($"You guess! + 2 score. Total score: {score}");
    }
    else
    {
        score--;
        Console.SetCursorPosition(0, 10);
        Console.WriteLine($"You lose! - 1 score. Total score: {score}");
    }
    flag = true;
    pos1x = 0;
    pos2x = 0;
    pos3x = 0;
    Console.WriteLine("\nPress enter to continue.");
    Console.ReadLine();
}
Console.Clear();
Console.WriteLine("You lose all score. Game over");