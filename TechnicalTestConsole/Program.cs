using System;
using TechnicalTestShared;

namespace TechnicalTestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Technical Test!");
            Console.Write("Text:");
            var textValue = Console.ReadLine();
            Console.WriteLine("Subtext:");
            var subtextValue = Console.ReadLine();

            var subTextMatcher = new SubTextMatcher();
            var subtextMatchResults = subTextMatcher.GetCharacterPositions(textValue,subtextValue);

            if (subtextMatchResults.DoesContainMatches)
                Console.WriteLine("Matches found at {0}", subtextMatchResults.StringForDisplay);
            else
                Console.WriteLine("No matches found");
        }
    }
}
