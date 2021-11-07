using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpBackend.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options) { }

        public DbSet<Todo> Todo { get; set; }
    }

    [Table("todo")]
    public class Todo
    {
        [Key]
        public int id { get; set; }

        public string status { get; set; }
        public string context { get; set; }
        public string DoneAt { get; set; }
    }
}
