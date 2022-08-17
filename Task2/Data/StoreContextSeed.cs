using Task2.Models;

namespace Task2.Data
{
	public class StoreContextSeed
	{
		public static async Task SeedAsync(StoreContext context)
		{
			if (context.Shops.Any())
				return;

			await context.AddAsync(new Shop
			{
				Name = "АвтоБай",
				Address = "г. Минск, ул. Петруся Бровки, 3",
				WorkingHours = "8:00 - 15:00",
				Items = new List<Item>()
					{
						new Item
						{
							Name = "Колесо",
							Description = "Большое круглое колесо хорошо подойдет для машины"
						},
						new Item
						{
							Name = "Дверь",
							Description = "Красная железная дверь"
						}
					}
			});
			await context.AddAsync(new Shop
			{
				Name = "ГомельСтрой",
				Address = "г. Гомель, ул. Якубовского, 3",
				WorkingHours = "12:00 - 20:00",
				Items = new List<Item>()
					{
						new Item
						{
							Name = "Молоток",
							Description = "Отлично подойдет для забивания гвоздей"
						},
						new Item
						{
							Name = "Топор",
							Description = "Можно срубить лес"
						},
						new Item
						{
							Name = "Пила",
							Description = "Для металла, дерева и пластика"
						},
						new Item
						{
							Name = "Гвозди",
							Description = "Отлично скрепляют деревья"
						}
					}
			});
			await context.SaveChangesAsync();
		}
	}
}
