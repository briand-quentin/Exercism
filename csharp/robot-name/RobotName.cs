using System;
using System.Collections.Generic;

public class Robot
{
    private static Random _random = new Random();

    private static List<string> RobotNamesNotAvailable = new List<string>();

    /// <summary>
    /// Creates a new robot
    /// </summary>
    public Robot()
    {
        GenerateRandomName();
    }

    /// <summary>
    /// The name of this robot
    /// </summary>
    public string Name { get; private set; }

    /// <summary>
    /// Resets the robot, giving it a new name
    /// </summary>
    public void Reset()
    {
        RobotNamesNotAvailable.Remove(Name);
        GenerateRandomName();
    }

    private void GenerateRandomName()
    {
        Name = $"{GetRandomLetter()}{GetRandomLetter()}{GetRandomDigits():000}";

        while (RobotNamesNotAvailable.Contains(Name))
        {
            Name = $"{GetRandomLetter()}{GetRandomLetter()}{GetRandomDigits():000}";
        }
        RobotNamesNotAvailable.Add(Name);
    }

    /// <summary>
    /// Gets a random letter from A to Z
    /// </summary>
    private char GetRandomLetter() => (char)('A' + _random.Next(26));

    /// <summary>
    /// Gets a random three digit number
    /// </summary>
    private int GetRandomDigits() => _random.Next(1000);
}