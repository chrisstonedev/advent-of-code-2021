﻿internal interface IDay
{
    int DayNumber { get; }
    int PartOneTestAnswer { get; }
    int PartTwoTestAnswer { get; }
    int ExecutePartOne(string[] input);
    int ExecutePartTwo(string[] input);
}