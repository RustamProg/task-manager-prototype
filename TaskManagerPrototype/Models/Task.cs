using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManagerPrototype.Models
{
    public class Task
    {
        [Key]
        public int Id { get; set; }
        
        [Column(TypeName = "nvarchar(200)")]
        public string Title { get; set; }
        
        [Column(TypeName = "nvarchar(2000)")]
        public string Description { get; set; }
        
        [Column(TypeName = "nvarchar(200)")]
        public string CreatedAtDateTime { get; set; }
        
        public int UserId { get; set; }

        public User User { get; set; }
    }
}