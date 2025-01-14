namespace FoodCompany.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public ApplicationDbContext _db;
        public IMenuItemRepository MenuItem { get;private set; }
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            MenuItem = new MenuItemRepository(_db);
          
        }
        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
