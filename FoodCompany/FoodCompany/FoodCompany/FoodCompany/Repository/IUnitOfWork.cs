namespace FoodCompany.Repository
{
    public interface IUnitOfWork
    {
        IMenuItemRepository MenuItem {  get; }
        void Save();
    }
}
