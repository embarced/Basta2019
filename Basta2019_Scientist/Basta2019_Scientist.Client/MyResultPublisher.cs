using System;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using GitHub;

namespace Basta2019_Scientist.Client
{
    internal class MyResultPublisher : IResultPublisher
    {
        public Task Publish<T, TClean>(Result<T, TClean> result)
        {
            if (result.Candidates.Count > 0)
            {
                if (result.Mismatched)
                {
                    Console.ForegroundColor = ConsoleColor.Red;                  
                }
                Console.WriteLine(string.Format("Default Result: {0}\t\t\tCandidate Result: {1}", result.Control.Value, result.Candidates.First().Value));
                Console.WriteLine(string.Format("Default Duration: {0}\tCandidate Duration: {1}", result.Control.Duration, result.Candidates.First().Duration));
                Console.ForegroundColor = ConsoleColor.Black;
            }

            Console.WriteLine();

            return Task.FromResult(0);
        }
    }
}