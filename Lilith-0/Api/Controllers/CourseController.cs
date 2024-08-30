using Microsoft.AspNetCore.Mvc;

namespace Lilith_0.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> CreateCourse()
        {
            return Created();
        }
    }
}
