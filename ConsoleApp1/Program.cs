using System;

int minValueMethod(int[] allages)
{
    int minValue = allages[0];
    for (int i = 0; i < allages.Length; i++)
    {
        if (allages[i] < minValue)
        {
            minValue = allages43[i];
        }

    }
    return minValue;

}

int[] takingValuesMethod(int[] allages)
{
    for (int i = 0; i < allages.Length; i++)
    {
        Console.WriteLine("Enter an integer:");
        string ages = Console.ReadLine();
        if (int.TryParse(ages, out int number))
        {
            Console.WriteLine($"The age you entered: {number}");
            Console.WriteLine(allages[i] = number);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter an integer.");
        }
    }
    return allages;
}
int[] values = {10,10,10};
Console.WriteLine("The smallest value in array is: " + minValueMethod(takingValuesMethod(values)));
