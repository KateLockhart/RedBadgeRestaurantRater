using RestaurantRaterRedBadge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestaurantRaterRedBadge.Controllers
{
    public class RestaurantController : Controller
    {
        //create a field to access database
        private RestaurantDbContext _db = new RestaurantDbContext();

        // GET: Restaurant/Index
        public ActionResult Index()
        {
            //add the restaurants from the data base to the view through a list
            return View(_db.Restaurants.ToList());
        }
    }
}