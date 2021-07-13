using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RestaurantRaterV2.Models
{
    public class RestaurantDBContext : DbContext
    {
        public RestaurantDBContext() : base("DefaultConnection") { }

        public DbSet<Restaurant> Restaurants { get; set; }

        public DbSet<Rating> Ratings { get; set; }
    }
}