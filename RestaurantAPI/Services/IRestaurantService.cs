﻿using RestaurantAPI.Models;
using System.Collections.Generic;
using System.Security.Claims;

namespace RestaurantAPI.Services
{
    public interface IRestaurantService
    {
        int Create(CreateRestaurantDto dto, int userId);
        IEnumerable<RestaurantDto> GetAll();
        RestaurantDto GetById(int id);
        void Delete(int id, ClaimsPrincipal user);
        void UpdateRestaurant(UpdateRestaurantDto dto, int id, ClaimsPrincipal user);
    }
}