using eTickets.Data.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Producer:IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Full Name is Required!")]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "Profile Picture is Required!")]
        [Display(Name = "Profile Picture URL")]
        public string ProfilePicture { get; set; }
        [Required(ErrorMessage = "Biography is Required!")]
        [Display(Name = "Biography")]
        public string Bio { get; set; }

        //Relationship
        public List<Movie> Movies { get; set; }
    }
}
