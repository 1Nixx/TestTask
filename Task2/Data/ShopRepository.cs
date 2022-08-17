using Microsoft.EntityFrameworkCore;
using Task2.Interfaces;
using Task2.Models;

namespace Task2.Data
{
	public class ShopRepository : IShopRepository
	{
		private readonly StoreContext _context;
		public ShopRepository(StoreContext context)
		{
			_context = context;
		}

		public async Task<List<Shop>> GetAllShopsAsync()
		{
			return await _context.Shops.ToListAsync();
		}

		public async Task<List<Item>> GetItemsByShopIdAsync(int id)
		{
			var shopWithItems = await (from shop in _context.Shops
									   where shop.Id == id
									   select shop).Include(p => p.Items).FirstAsync();
			return shopWithItems.Items;
		}

		public async Task<Shop> GetShopByIdAsync(int id)
		{
			return await (from shop in _context.Shops
						  where shop.Id == id
						  select shop).FirstAsync();
		}
	}
}
