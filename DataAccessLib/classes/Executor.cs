using System.ComponentModel.DataAnnotations;

namespace DataAccessLib.classes
{
    public class Executor
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [StringLength(20, MinimumLength=3)]
        public string? Name { get; set; }
    }
}
