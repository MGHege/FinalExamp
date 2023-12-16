int[] array = Console.ReadLine().Split("@", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

int lastPosition = 0;
int successMision = 0;

while (command[0] != "Love!")
{
    int jumpLength = int.Parse(command[1]);
    lastPosition += jumpLength;

    if (lastPosition < 0 || lastPosition >= array.Length)
    {
        lastPosition = 0;
    }

    if (array[lastPosition] != 0)
    {
        array[lastPosition] -= 2;

        if (array[lastPosition] == 0)
        {
            successMision++;
            Console.WriteLine($"Place {lastPosition} has Valentine's day.");
        }
    }
    else
    {
        Console.WriteLine($"Place {lastPosition} already had Valentine's day.");
    }

    command = Console.ReadLine().Split().ToArray();
}

Console.WriteLine($"Cupid's last position was {lastPosition}.");

if (successMision == array.Length)
{
    Console.WriteLine("Mission was successful.");
}
else
{
    Console.WriteLine($"Cupid has failed {array.Length - successMision} places.");
}