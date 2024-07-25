using System;

class Program
{
    static void Main()
    {
        try
        {
           
            Console.Write("Input a numeric integer: ");
            int number = Convert.ToInt32(Console.ReadLine());

           
            ValidateNumberRange(number);

            
            Console.WriteLine("Valid input: " + number);
        }
        catch (NumberOutOfRangeException ex)
        {
            
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (FormatException)
        {
            
            Console.WriteLine("Error: Invalid input. Please enter a numeric integer.");
        }
        catch (Exception ex)
        {
            
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }

    
    static void ValidateNumberRange(int number)
    {
        if (number < 0 || number > 1000)
        {
            
            throw new NumberOutOfRangeException("Number out of range. Please enter a number between 0 and 1000.");
        }
    }
}


class NumberOutOfRangeException : Exception
{
    public NumberOutOfRangeException(string message) : base(message) { }
}
