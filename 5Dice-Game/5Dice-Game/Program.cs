using System;

Random random = new Random();
List<int> dices = new List<int>();
List<bool> keep = new List<bool>();
String diceValues;
int throws = 3;

for (int i = 0; i < 5; i++)
{
    int roll = random.Next(1, 7);                   // randomizes the roll
    dices.Add(roll);                                // adds that number to the list "dices"
    //Console.WriteLine($"Dice {i + 1}: {roll}");     // outputs that number into the console
    keep.Add(false);
}

while (throws > 0)
{
    throws--;

    for (int i = 1; i <= 5; i++)
    {
        if (keep[i - 1] == false)
        {
            dices[i - 1] = random.Next(1, 7);
            int roll = dices[i - 1];
            Console.WriteLine($"Dice {i}: {roll}");
        }
        else
        {
            Console.WriteLine($"Dice {i}: {dices[i - 1]}");
        }
    }
    keep.Clear();
    for (int i = 0; i < 5; i++)
    {
        keep.Add(false);
    }
    if (throws == 0)
    {
        Console.WriteLine("What dices do you want to use?");
    }
    else
    {
        Console.WriteLine("What dices would you like to keep? (Example: 1 3 5)");
    }

    diceValues = Console.ReadLine();
    string[] values = diceValues.Split(' ');

    foreach (var val in values)
    {
        if (int.TryParse(val, out int number))
        {
            if (number >= 1 && number <= 5)
            {
                keep[number - 1] = true;
            }
        }
    }
    
}

//Console.WriteLine(string.Join(' ', values));

Console.ReadKey();
