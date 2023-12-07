using System;

class ReadWriteInt
{


  static int minValueMethod(int[] allages)
  {
 int minValue = allages[0];
    for (int i=0;i<allages.Length;i++){
      if (allages[i]<minValue)
      {
        minValue = allages[i];
      }
       
    }
    return minValue;

  }
    static void Main(string[] args)
    {

      int[] allages = {10,10,10};
           
    for (int i = 0; i<allages.Length ; i++)
      {     
        // Prompt the user to enter an integer
        Console.WriteLine("Enter an integer:");

        // Read the user input as a string
        string ages = Console.ReadLine();

        // Check if the input can be parsed as an integer
        if (int.TryParse(ages, out int number))
        {
            // Write the parsed integer to the console
            Console.WriteLine($"The age you entered: {number}");
            Console.WriteLine(allages[i] = number);
        }
        else
        {
            // Handle invalid input
            Console.WriteLine("Invalid input. Please enter an integer.");
        }
    }
   
  Console.WriteLine("The smallest value in array is: " + minValueMethod(allages));
}
}
