using Lilith_0.Domain.Entities;
using MediatR;

namespace Lilith_0.Application.Queries.Courses
{
    public record GetCoursesQuery() : IRequest<List<Course>>
    {
    }
}
