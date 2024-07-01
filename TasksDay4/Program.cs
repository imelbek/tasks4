/*
 * Used tools are "if-else" condition, "goto"
 */

// Task 1: There are 2 values (a and b) where a < b. Find Sum of the values between a and b

// label
newChance:

Console.Write("Enter 1st value: ");
int a = Int32.Parse(Console.ReadLine());

Console.Write("Enter 2nd value: ");
int b = Int32.Parse(Console.ReadLine());

int res = 0;

if (a > b || a + 1 == b)
{
    Console.WriteLine("Please, choose other values \n");
    goto newChance;
}

else
{
    for (int i = a + 1; i < b; i++)
        res = res + i;
    
    Console.WriteLine($"Sum between {a} and {b} is {res}");
}


// Task 2: There are 2 values (a and b) where a < b. Display all odd nums (num % 2 = 1)

if (a > b || a + 1 == b)
{
    Console.WriteLine("Please, choose other values \n");
    goto newChance;
}

else
{
    for (int i = a + 1; i < b; i++)
    {
        if (i % 2 != 0)
            Console.Write(i + " ");
        else Console.WriteLine($"No odd number(s) between {a} and {b}.");
    }
}