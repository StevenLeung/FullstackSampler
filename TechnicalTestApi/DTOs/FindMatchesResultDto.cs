using System.Collections.Generic;

namespace TechnicalTestApi.Controllers
{
    public class FindMatchesResultDto
    {
        public List<int> CharacterPositions { get; protected set; }

        public FindMatchesResultDto()
        {
            CharacterPositions = new List<int>();
        }

        public void AddCharacterPositions(IEnumerable<int> collection)
        {
            CharacterPositions.AddRange(collection);
        }
    }
}
