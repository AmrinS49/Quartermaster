using Domain;

namespace Persistence
{
    public class Seed
    {

        public static async Task SeedData(DataContext context)
        {

            if (context.Items.Any()) return;    // Do not seed if database is populated

            var items = new List<Item>
            {
                new Item
                {
                    Sku = "WCP-0783",
                    Name = "1/2\" Hex Bearing",
                    Quantity = 35,
                    Type = "Bearing",
                    Link = "https://wcproducts.com/collections/cnc-hardware/products/ball-bearings"
                },
                new Item
                {
                    Sku = "217-2735",
                    Name = "3/8\" Hex Bearing",
                    Quantity = 2,
                    Type = "Bearing",
                    Link = "https://wcproducts.com/collections/cnc-hardware/products/ball-bearings"
                },
                new Item
                {
                    Sku = "WCP-0781",
                    Name = "1/2\" Round Bearing",
                    Quantity = 56,
                    Type = "Bearing",
                    Link = "https://wcproducts.com/collections/cnc-hardware/products/ball-bearings"
                },
                new Item
                {
                    Sku = "WCP-0780",
                    Name = "3/8\" Round Bearing",
                    Quantity = 0,
                    Type = "Bearing",
                    Link = "https://wcproducts.com/collections/cnc-hardware/products/ball-bearings"
                }
            };

            await context.Items.AddRangeAsync(items);
            await context.SaveChangesAsync();

        }        
    }
}