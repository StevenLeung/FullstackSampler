using Microsoft.AspNetCore.Mvc;
using TechnicalTestShared;

namespace TechnicalTestApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MatchesController : ControllerBase
    {
        private readonly ISubtextMatchFinder _subTextMatchFinder;

        public MatchesController(ISubtextMatchFinder subtextMatchFinder)
        {
            _subTextMatchFinder = subtextMatchFinder;
        }

        [HttpPost("find")]
        public IActionResult FindMatches(FindMatchesInputDto inputDto)
        {
            var responseToUser = new FindMatchesResultDto();

            var subtextMatchResults = _subTextMatchFinder.FindMatches(inputDto.text, inputDto.subtext);

            if (subtextMatchResults.DoesContainMatches)
            {
                responseToUser.AddCharacterPositions(subtextMatchResults.FoundCharacterPositions);
            }

            return Ok(responseToUser);
        }
    }
}
