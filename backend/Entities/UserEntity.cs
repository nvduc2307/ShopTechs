using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace Entities
{
    public class UserEntity {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? PassWord { get; set; }
        [Required]
        public DateTime CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }
        public DateTime? DeleteAt { get; set; }
    }

    public class UserLogin {
        public string? UserName { get; set; }
        public string? PassWord { get; set; }
    }
}