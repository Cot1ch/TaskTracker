using System.ComponentModel.DataAnnotations;

namespace DataAccessLib.classes
{
    public class Executor
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [StringLength(25, MinimumLength=1, ErrorMessage="Недопустимая длина [от 1 до 25]")]
        public string? Name { get; set; }
    }
}
