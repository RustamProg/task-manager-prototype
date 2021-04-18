using System.ComponentModel.DataAnnotations;

namespace TaskManagerPrototype.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public string UserInfo { get; set; }
    }
}