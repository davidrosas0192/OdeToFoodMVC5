using OdeToFood.NetFrameWork.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.NetFrameWork.Data.Services
{
    public class OdeToFoodDbContext:DbContext
    {

        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
