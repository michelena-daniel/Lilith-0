namespace Lilith_0.Domain.Entities
{
    public class Course
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public Guid? InstructorId { get; set; }
        public string? Level { get; set; }
        public string? Category { get; set; }
        public TimeSpan Duration { get; set; }
    }
}
