using System;

// Author: [mohammed ali]
// Course: [comp003AL01]
// Purpose: Demonstrating C# method usage and documentation

class Program
{
    static void Main()
    {
        // Calling PrintSeparator method with the parameter "Triangle"
        PrintSeparator("Triangle");

        // Requesting user input for character and size
        Console.Write("Enter a character: ");
        char inputCharacter = Console.ReadKey().KeyChar;
        Console.WriteLine();
        Console.Write("Enter a positive whole number: ");
        int size = int.Parse(Console.ReadLine());

        // Calling IsoscelesTriangleBuilder method with user inputs as parameters
        IsoscelesTriangleBuilder(inputCharacter, size);

        // Calling PrintSeparator method with the parameter "Favorite Characters"
        PrintSeparator("Favorite Characters");

        // Calling CharacterInfo method for favorite characters and their birth or first appearance years
        CharacterInfo("Superman", 1938);
        CharacterInfo("Spider-Man", 1962);
        CharacterInfo("Batman", 1939);
        CharacterInfo("Wonder Woman", 1941);
        CharacterInfo("Iron Man", 1963);
    }

    // Method to print a separator line with 50 asterisks
    static void PrintSeparator()
    {
        Console.WriteLine(new string('*', 50));
    }

    // Method to print a separator line with a custom character
    static void PrintSeparator(string separator)
    {
        Console.WriteLine(new string(separator[0], 50));
    }

    /// <summary>
    /// Builds an isosceles triangle using the inputCharacter and size parameters.
    /// </summary>
    /// <param name="inputCharacter">The character used to build the triangle.</param>
    /// <param name="size">The size of the triangle.</param>
    static void IsoscelesTriangleBuilder(char inputCharacter, int size)
    {
        // Increasing part of the triangle
        for (int i = 1; i <= size; i++)
        {
            Console.WriteLine(new string(inputCharacter, i));
        }

        // Decreasing part of the triangle
        for (int i = size - 1; i >= 1; i--)
        {
            Console.WriteLine(new string(inputCharacter, i));
        }
    }

    /// <summary>
    /// Calculates the age based on the provided year.
    /// </summary>
    /// <param name="year">The year to calculate the age from.</param>
    /// <returns>The calculated age.</returns>
    static int AgeCalculator(int year)
    {
        int currentYear = DateTime.Now.Year;
        return currentYear - year;
    }

    /// <summary>
    /// Outputs the name and age of a character based on the provided birthYear.
    /// </summary>
    /// <param name="name">The name of the character.</param>
    /// <param name="birthYear">The birth year or first appearance year of the character.</param>
    static void CharacterInfo(string name, int birthYear)
    {
        int age = AgeCalculator(birthYear);
        Console.WriteLine($"{name} is {age} years old.");
    }
}