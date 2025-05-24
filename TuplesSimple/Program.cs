﻿(int, double) SumAndAverage(params int[]arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        sum += arr[i];
    }
    double avg = sum / arr.Length;
    return (sum, avg);
}

int []arr = { 1, 2, 3, 4, 5, 6 };
(int s, double a) = SumAndAverage(arr);
Console.WriteLine($"Sum = {s}");
Console.WriteLine($"Average = {a}");
