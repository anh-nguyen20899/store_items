using Catalog.Dtos;
using Catalog.Entities;

namespace Catalog.Repositories
{

    // public class InMemItemsRepository : IItemRepository
    // {
    //     public readonly List<Item> items = new()
    //     {
    //         new Item {ID = Guid.NewGuid(), Name = "Potion", Price = 9, CreatedDate = DateTimeOffset.UtcNow},
    //         new Item {ID = Guid.NewGuid(), Name = "Sword", Price = 20, CreatedDate = DateTimeOffset.UtcNow},
    //         new Item {ID = Guid.NewGuid(), Name = "Shield", Price = 18, CreatedDate = DateTimeOffset.UtcNow}
    //     };

    //     public IEnumerable<Item> GetItemsAsync()
    //     {
    //         return items;
    //     }

    //     public Item GetItemAsync(Guid Id)
    //     {
    //         return items.Where(item => item.ID == Id).SingleOrDefault();
    //     }
    //     public void CreateItemAsync(Item item)
    //     {           
    //         items?.Add(item);
    //     }

    //     public void UpdateItemAsync(Item updatedItem)
    //     {
    //         var IndexOfItem = items?.FindIndex(existingItem => existingItem.ID == updatedItem.ID);
    //         int index = (int) IndexOfItem;
    //         items[index] = updatedItem;        
    //     }

    //     public void DeleteItemAsync(Guid id)
    //     {
    //         int IndexOfItem = items.FindIndex(existingItem => existingItem.ID == id);
    //         items.RemoveAt(IndexOfItem);
    //     }
    // }
}