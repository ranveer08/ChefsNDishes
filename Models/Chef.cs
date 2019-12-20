using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ChefsNDishes.Models
{
    public class Chef
    {
        [Key]
        public int ChefId {get; set;}

        [RegularExpression(@"[a-zA-Z'\s]*$", ErrorMessage = "Name should be only letters and spaces")]
        [Required]
        [StringLength(30)]
        [Display(Name = "First Name")]
        public string FirstName {get; set;}

        [RegularExpression(@"[a-zA-Z'\s]*$", ErrorMessage = "Name should be only letters and spaces")]
        [Required]
        [StringLength(30)]
        [Display(Name = "Last Name")]
        public string LastName {get; set;}

        [Required]
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth {get; set;}
        public int Age {get; set;}
        public List<Dish> AddedDishes {get; set;}
        public DateTime CreatedAt {get; set;} = DateTime.Now;
        public DateTime UpdatedAt {get; set;} = DateTime.Now;


       
    }
}