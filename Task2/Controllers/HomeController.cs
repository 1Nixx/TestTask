using Microsoft.AspNetCore.Mvc;
using Task2.Data;
using Task2.Interfaces;
using Task2.Models;

namespace Task2.Controllers
{
	public class HomeController : Controller
	{
		private readonly IShopRepository _shopRepository;

		public HomeController(IShopRepository shopRepository)
		{
			_shopRepository = shopRepository;
		}

		public async Task<IActionResult> Index()
		{
			var shops = await _shopRepository.GetAllShopsAsync();

			ViewData["Title"] = "Все магазины";
			return View(shops);
		}


		public async Task<IActionResult> Items(int id)
		{
			var items = await _shopRepository.GetItemsByShopIdAsync(id);
			var shop = await _shopRepository.GetShopByIdAsync(id);

			ViewData["Title"] = $"Товары магазина {shop.Name}";
			return View(items);
		}

		public IActionResult Error()
		{
			ViewData["Title"] = "!Ошибка!";
			return View();
		}
	}
}