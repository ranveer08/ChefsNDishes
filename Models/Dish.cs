using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChefsNDishes.Models
{
    public class Dish
    {
        [Key]
        public int DishId {get; set;}

        [Required]
        [RegularExpression(@"[a-zA-Z'\s]*$", ErrorMessage = "Dish name should be only letters and spaces")]
        [StringLength(30)]
        [Display(Name = "Name of Dish")]
        public string Name {get; set;}

        [Required]
        [Display(Name = "# of Calories")]
        [Range(1, Int32.MaxValue, ErrorMessage = "Calories must be greater than zero")]
        public int Calories {get; set;}

        [Required]
        [RegularExpression(@"[a-zA-Z'\s]*$", ErrorMessage = "Description should be only letters and spaces")]
        [StringLength(155)]
        public string Description {get; set;}

        [Required]
        [Display(Name= "Chef")]
        public int ChefId {get; set;}
        public Chef Chef {get; set;}
        [Required]
        public int Tastiness {get; set;}       
    }
}