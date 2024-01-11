/*
Problem description: Given a single-dimensional array of scores, find the minimum, maximum, and average of the scores.

Programmer: Olivia Daake

Requirements:
1. The array of scores must be passed as a parameter to the function.
2. The function must return the minimum, maximum, and average of the scores.


Algorithm
1. List out the scores being used for the single-dimesional array.
2. Create a function that will return the minimum, maximum, and average of the scores.
3. Print the minimum, maximum, and average of the scores.


*/

using System;

class Program
{
    static void Main()
    {
        // Single-dimension array of scores
        int[] scores = { 80, 67, 90, 90, 100 };

        //Find minimum score
        int min = scores[0];

        for (int i = 1; i < scores.Length; i++)
        {
            if (scores[i] < min)
            {
                min = scores[i];
            }
        }

        //Find maximum score
        int max = scores[0];
        for (int i = 1; i < scores.Length; i++)
        {
            if (scores[i] > max)
            {
                max = scores[i];
            }
        }

        //Find the average score
        int sum = 0;
        for (int i = 0; i < scores.Length; i++)
        {
            sum += scores[i];
        }
        double average = (double)sum / scores.Length;

        //Print the minimum, maximum, and average score
        Console.WriteLine("Minimum score: " + min);
        Console.WriteLine("Maximum score: " + max);
        Console.WriteLine("Average score: " + average);

    }
}