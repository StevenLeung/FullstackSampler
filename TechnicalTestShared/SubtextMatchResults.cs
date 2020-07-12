using System.Collections.Generic;

namespace TechnicalTestShared
{
    public interface ISubtextMatchResults
    {
        bool DoesContainMatches { get; }
        string StringForDisplay { get; }

        void AddFoundPosition(int position);

        List<int> FoundCharacterPositions { get; }
    }

    public class SubtextMatchResults : ISubtextMatchResults
    {
        private const string delimiterCharacter = ",";
        private readonly List<int> _characterPositions;

        public bool DoesContainMatches
        {
            get { return _characterPositions.Count > 0; }
        }

        public string StringForDisplay
        {
            get { return string.Join(delimiterCharacter, _characterPositions); }
        }

        public List<int> FoundCharacterPositions => _characterPositions;

        public SubtextMatchResults()
        {
            _characterPositions = new List<int>();
        }

        public void AddFoundPosition(int foundPosition)
        {
            _characterPositions.Add(foundPosition);
        }
    }
}