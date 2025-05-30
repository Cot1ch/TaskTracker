using System.ComponentModel.DataAnnotations;


namespace DataAccessLib.classes
{
    public class Taska
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Недопустимая длина [от 3 до 50]")]
        public string? Title { get; set; }
        public string? Description { get; set; }
        [Required]
        public string? Priority { get; set; }
        [Required]
        public Executor Executor { get; set; }
        public Guid ExecutorId { get; set; }
        public bool Status { get; set; } = false;
    }
}
