using FoodCompany.Models;

namespace FoodCompany.Repository
{
    public interface IMenuItemRepository:IRepository<MenuItem>

    {
        void Update(MenuItem obj);
    }
}
