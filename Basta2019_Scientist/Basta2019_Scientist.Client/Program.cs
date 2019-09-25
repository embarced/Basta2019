﻿using System;
using Basta2019_Scientist.ComplicatedCalculation;
using Basta2019_Scientist.ComplicatedCalculation.v2;
using GitHub;

namespace Basta2019_Scientist.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IResultPublisher publisher = new MyResultPublisher();
            Scientist.ResultPublisher = publisher;

            for (int i = 0; i < 5; i++)
            {
                int randomInput = new Random().Next(4);

                Console.WriteLine($"Random num is: {randomInput}");

                int result = Scientist.Science<int>("First experiment", experiment =>
                {
                    experiment.AddContext("Random Data", randomInput);

                    experiment.Use(() => new ComplicatedCalc_V1().GetResult(randomInput)); // Old Version
                    experiment.Try(() => new ComplicatedCalc_V2().GetResult(randomInput)); // New Version
                });
                //Console.WriteLine($"Result: {result}"); // Result is always Old Version
            }

        }
    }
}
