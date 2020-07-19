using System.ComponentModel.DataAnnotations;

namespace TechnicalTestApi.Controllers
{
    public class FindMatchesInputDto
    {
        [Required]
        public string text { get; set; }

        [Required]
        public string subtext { get; set; }
    }
}