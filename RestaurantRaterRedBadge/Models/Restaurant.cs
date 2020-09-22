using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RestaurantRaterRedBadge.Models
{
    public class Restaurant
    {
        public int RestaurantID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Rating { get; set; }
    }
    //snapshot of the server
    public class RestaurantDbContext : DbContext
    { 
        public DbSet<Restaurant> Restaurants { get; set; }

    }
}