using System;

public static class CollatzConjecture
{
    public static int Steps(int number, int steps = 0)
    {
        if (number <= 0)
        {
            throw new ArgumentException("Only numbers greater than zero are allowed");
        }

        if (number == 1) return steps;
        if (number % 2 == 0) return Steps(number / 2, ++steps);
        return Steps(3 * number + 1, ++steps);

    }
}