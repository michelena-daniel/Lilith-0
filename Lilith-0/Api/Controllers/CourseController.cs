using Lilith_0.Application.Commands.Courses;
using Lilith_0.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Lilith_0.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly IMediator _mediator;
        private ILogger<CourseController> _logger;

        public CourseController(IMediator mediator, ILogger<CourseController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCourse([FromBody] CreateCourseCommand command)
        {
            //_logger.LogInformation($"Init create course with course id: {course.Id}");
            //var command = new CreateCourseCommand { Course = course };
            var courseId = await _mediator.Send(command);
            //_logger.LogInformation($"Created course successfully for course id: {course.Id}");

            return Ok(courseId);
        }
    }
}
