using Lilith_0.Application.Queries.Courses;
using Lilith_0.Data;
using Lilith_0.Domain.Entities;
using MediatR;

namespace Lilith_0.Application
{
    public class GetCoursesHandler : IRequestHandler<GetCoursesQuery, List<Course>>
    {
        private readonly ApplicationDbContext _dbContext;

        public GetCoursesHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<List<Course>> Handle(GetCoursesQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_dbContext.Courses.ToList());
        }
    }
}
