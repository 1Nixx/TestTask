using Task2.Models;

namespace Task2.Interfaces
{
	public interface IShopRepository
	{
		Task<List<Shop>> GetAllShopsAsync();
		Task<List<Item>> GetItemsByShopIdAsync(int id);
		Task<Shop> GetShopByIdAsync(int id);
	}
}
