using Lilith_0.Domain.Entities;
using MediatR;

namespace Lilith_0.Application.Commands.Courses
{
    public record CreateCourseCommand() : IRequest<Guid>
    {
        public Course Course { get; set; }
    }
}