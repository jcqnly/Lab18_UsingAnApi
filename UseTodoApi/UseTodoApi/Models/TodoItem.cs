using System.ComponentModel.DataAnnotations;

namespace UseTodoApi.Models
{
    public class TodoItem
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public bool IsComplete { get; set; }

        public int ListId { get; set; }
    }
}
