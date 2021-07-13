using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestaurantRaterV2.Models
{
    public class Restaurant
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        public double Rating
        {
            get
            {
                double totalAverageRating = 0;
                foreach (Rating rating in Ratings)
                {
                    totalAverageRating += rating.AverageRating;
                }

                return (Ratings.Count > 0) ? totalAverageRating / Ratings.Count : 0;
            }
        }
        [Key]
        public int Id { get; set; }

        public virtual List<Rating> Ratings { get; set; } = new List<Rating>();

    }
}