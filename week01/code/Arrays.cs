public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
    

    // Step 1: Validate inputs
    // - Check if 'length' is less than or equal to 0. If so, return an empty array.
    // - This ensures the function does not attempt to create an array of negative or zero length.
    
    if (length <= 0)
    {
        return new double[0]; // Return an empty array if the length is invalid
    }

    // Step 2: Initialize the result array
    // - Create an array called 'multiples' of type double with a size equal to 'length'.
    
    double[] multiples = new double[length];

    // Step 3: Calculate the multiples
    // - Use a for loop to iterate from 0 to 'length - 1'.
    // - For each index 'i', calculate the multiple as 'number * (i + 1)' and store it in the array.

    for (int i = 0; i < length; i++)
    {
        multiples[i] = number * (i + 1);
    }

    // Step 4: Return the result array
    // - After the loop, return the 'multiples' array which now contains the calculated multiples.

    return multiples; // Return the array of multiples
        }
    

class Program 
{
    public static void Main(string[] args)
    {
        Run();
    }

    public static void Run()
    {
        // Prompt the user for input
        Console.WriteLine("Enter a number to find its multiples:");
        double number = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the number of multiples:");
        int length = Convert.ToInt32(Console.ReadLine());

        // Call the MultiplesOf function
        double[] result = Arrays.MultiplesOf(number, length);

        // Display the result
        Console.WriteLine($"Multiples of {number}: " + string.Join(", ", result));
    }

}






    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
    }
}
