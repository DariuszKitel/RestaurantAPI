using RestaurantAPI.Models;

namespace RestaurantAPI.Services
{
    public interface IAccountService
    {
        public void RegisterUser(RegisterUserDto dto);

    }
}