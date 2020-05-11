using System.Collections.Generic;

namespace TechnicalTestShared
{
    public interface ICharacterPositionCollection
    {
        bool DoesContainMatches { get; }
        string StringForDisplay { get; }

        void AddFoundPosition(int position);
    }

    public class CharacterPositionCollection : ICharacterPositionCollection
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

        public CharacterPositionCollection()
        {
            _characterPositions = new List<int>();
        }

        public void AddFoundPosition(int foundPosition)
        {
            _characterPositions.Add(foundPosition);
        }
    }
}