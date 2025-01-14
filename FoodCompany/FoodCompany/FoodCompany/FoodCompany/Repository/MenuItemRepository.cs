using FoodCompany.Models;

using System.Linq.Expressions;

namespace FoodCompany.Repository
{
    public class MenuItemRepository : Repository<MenuItem>, IMenuItemRepository
    {
        public ApplicationDbContext _db;
        public MenuItemRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(MenuItem obj)
        {
            _db.MenuItem.Update(obj);
        }
    }

}
