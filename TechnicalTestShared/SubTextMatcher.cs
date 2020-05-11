using System.Collections.Generic;

namespace TechnicalTestShared
{
    public interface ISubTextMatcher
    {
        ICharacterPositionCollection GetCharacterPositions(string text, string subtext);
    }

    public class SubTextMatcher : ISubTextMatcher
    {
        public ICharacterPositionCollection GetCharacterPositions(string text, string subtext)
        {
            ICharacterPositionCollection result = new CharacterPositionCollection();

            var startIndex = 0;
            do
            {
                var indexof = text.ToLower().IndexOf(subtext.ToLower(), startIndex);
                if (indexof > -1)
                {
                    result.AddFoundPosition(indexof);
                    startIndex = (indexof + subtext.Length);
                }
                else
                    break;

            } while (startIndex < text.Length);

            return result;
        }
    }
}
