using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace UserRegistry.Models
{
    public class Register
    {
        [Key]
        public int ID { get; set; }

        [StringLength(50)]
        [Required]
        [Display(Name ="Last Name")]
        public string LastName { get; set; }

        [StringLength(50)]
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [StringLength(1)]
        [Required]
        [Display(Name = "Middle Initial")]
        public string MiddleInitial { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required]
        public string Email { get; set; }

        [StringLength(16)]
        [Required]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required]
        [Display(Name = "Register Date")]
        public DateTime RegisterDate { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
