namespace TechnicalTestShared
{
    public interface ISubtextMatchFinder
    {
        ISubtextMatchResults FindMatches(string text, string subtext);
    }

    public class SubtextMatchFinder : ISubtextMatchFinder
    {
        public ISubtextMatchResults FindMatches(string text, string subtext)
        {
            ISubtextMatchResults result = new SubtextMatchResults();
            var santisedSubtext = subtext.Trim().ToLower();
            var santisedSubtextLength = santisedSubtext.Length;

            var startIndex = 0;
            do
            {
                var indexof = text.ToLower().IndexOf(santisedSubtext, startIndex);
                if (indexof < 0)
                {
                    break;
                }

                result.AddFoundPosition(indexof);
                startIndex = (indexof + santisedSubtextLength);

            } while (startIndex < text.Length);

            return result;
        }
    }
}
