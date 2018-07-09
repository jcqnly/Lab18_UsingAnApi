using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UseTodoApi.Models
{
    public class TodoList
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Display(Name = "All the todo items")]
        public List<TodoItem> TodoItems { get; set; }
    }
}
