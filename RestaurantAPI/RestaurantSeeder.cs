using RestaurantAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAPI
{
    public class RestaurantSeeder
    {
        private readonly RestaurantDbContext _dbContext;

        public RestaurantSeeder(RestaurantDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Seed()
        {
            if (_dbContext.Database.CanConnect())
            {
                if (!_dbContext.Restaurants.Any())
                {
                    var restaurants = GetRestaurants();
                    _dbContext.Restaurants.AddRange(restaurants);
                    _dbContext.SaveChanges();
                }
            }
        }

        private IEnumerable<Restaurant> GetRestaurants()
        {
            return new List<Restaurant>()
            {
                new Restaurant()
                {
                    Name = "KFC",
                    Category = "Fast Food",
                    Description = "Fast Description",
                    ContactEmail = "kfc@gmail.com",
                    HasDelivery = true,
                    Dishes = new List<Dish>()
                    {
                        new Dish()
                        {
                            Name = "Wrap",
                            Price = 10.20M,
                        },
                        new Dish()
                        {
                            Name = "Nuggets",
                            Price = 5.20M,
                        },
                    },
                    Address = new Address()
                    {
                        City = "Sosnowiec",
                        Street = "Polna 1",
                        PostalCode = "41-200",
                    }
                },
                new Restaurant()
                {
                    Name = "MCDonalds",
                    Category = "Slow Food",
                    Description = "Slow Description",
                    ContactEmail = "Mc@gmail.com",
                    HasDelivery = false,
                    Dishes = new List<Dish>()
                    {
                        new Dish()
                        {
                            Name = "Burger",
                            Price = 8.20M,
                        },
                        new Dish()
                        {
                            Name = "Pita",
                            Price = 3.99M,
                        },
                    },
                    Address = new Address()
                    {
                        City = "Sosnowiec",
                        Street = "Rolna 1",
                        PostalCode = "41-220",
                    }
                }
            };
        }
    }
}
