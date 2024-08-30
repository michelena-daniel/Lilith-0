using Lilith_0.Application.Commands.Courses;
using Lilith_0.Data;
using MediatR;

namespace Lilith_0.Application
{
    public class CreateCourseHandler : IRequestHandler<CreateCourseCommand, Guid>
    {
        private readonly ApplicationDbContext _dbContext;

        public CreateCourseHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateCourseCommand request, CancellationToken cancellationToken)
        {
            var course = request.Course;
            _dbContext.Courses.Add(course);
            await _dbContext.SaveChangesAsync(cancellationToken);
            return course.Id;
        }
    }
}
