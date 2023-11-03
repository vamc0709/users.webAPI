using System.ComponentModel.DataAnnotations;

namespace users.webAPI.Models;

   public class usersModel
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        [MaxLength(20)]
        public string Username { get; set; }
        [Required]
        [MaxLength(20)]
        public string Password  { get; set; }
        [Required]
        [MaxLength(40)]
        public string Email { get; set; }

        public DateTime LoginTime{get; set; }
    }
