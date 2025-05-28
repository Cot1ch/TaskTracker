using System.ComponentModel.DataAnnotations;


namespace DataAccessLib.classes
{
    public class Taska
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [StringLength(50, MinimumLength = 3)]
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Priority { get; set; }
        public Executor Executor { get; set; }
        public bool Status { get; set; } = false;
    }
}
