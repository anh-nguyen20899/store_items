using Catalog.Entities;
using Catalog.Dtos;
namespace Catalog.Repositories
{
    public interface IItemRepository
    {
        Task<Item> GetItemAsync(Guid Id);
        Task<IEnumerable<Item>> GetItemsAsync();
        Task CreateItemAsync(Item item);
        Task UpdateItemAsync(Item item);
        Task DeleteItemAsync(Guid id);

    }
}
