﻿namespace FootballTeamGenerator.Models;

public class Player
{
    private const string StatPropertyExceptionMessage = "{0} should be between 0 and 100.";
    private const int MinValue = 0;
    private const int MaxValue = 100;

    private string name;
    private int endurance;
    private int sprint;
    private int dribble;
    private int passing;
    private int shooting;
    public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
    {
        Name = name;
        Endurance = endurance;
        Sprint = sprint;
        Dribble = dribble;
        Passing = passing;
        Shooting = shooting;
    }

    public string Name
    {
        get => name;
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("A name should not be empty.");
            }

            name = value;
        }
    }
    public int Endurance
    {
        get => endurance;
        private set
        {
            if (value < MinValue || value > MaxValue)
            {
                throw new ArgumentException(string.Format(StatPropertyExceptionMessage, nameof(Endurance)));
            }

            endurance = value;
        }
    }
    public int Sprint
    {
        get => sprint;
        private set
        {
            if (value < MinValue || value > MaxValue)
            {
                throw new ArgumentException(string.Format(StatPropertyExceptionMessage, nameof(Sprint)));
            }

            sprint = value;
        }
    }
    public int Dribble
    {
        get => dribble;
        private set
        {
            if (value < MinValue || value > MaxValue)
            {
                throw new ArgumentException(string.Format(StatPropertyExceptionMessage, nameof(Dribble)));
            }

            dribble = value;
        }
    }
    public int Passing
    {
        get => passing;
        private set
        {
            if (value < MinValue || value > MaxValue)
            {
                throw new ArgumentException(string.Format(StatPropertyExceptionMessage, nameof(Passing)));
            }

            passing = value;
        }
    }
    public int Shooting
    {
        get => shooting;
        private set
        {
            if (value < MinValue || value > MaxValue)
            {
                throw new ArgumentException(string.Format(StatPropertyExceptionMessage, nameof(Shooting)));
            }

            shooting = value;
        }
    }
    public double SkillLevel => (Endurance + Sprint + Dribble + Passing + Shooting) / 5.0;
}
