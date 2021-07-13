using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RestaurantRaterV2.Models
{
    public class Rating
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Range(0, 10)]
        public double FoodRating { get; set; }
        [Required]
        [Range(0, 10)]
        public double CleanlinessRating { get; set; }
        [Required]
        [Range(0, 10)]

        public double CustomerServiceRating { get; set; }
        [Required]
        [Range(0, 10)]
        public double AverageRating
        {
            get
            {
                return (FoodRating + CleanlinessRating + CustomerServiceRating) / 3;
            }
        }

        [ForeignKey(nameof(Restaurant))]
        public int RestaurantId { get; set; }
        public virtual Restaurant Restaurant { get; set; }
    }
}