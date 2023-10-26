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
                new Bearing
                {
                    Sku = "WCP-0783",
                    SkuAlias = "217-3875",
                    Name = "1/2\" Hex Bearing",
                    Quantity = 35,
                    Type = "Bearing",
                    Link = "https://wcproducts.com/collections/cnc-hardware/products/ball-bearings",
                    Flange = true,
                    BoreType = "Hex",
                    Vendor = "WestCoast Products",
                    OuterDiameter = 1.125,
                    InnerDiameter = 0.5,
                    Width = 0.313,
                },
                new Bearing
                {
                    Sku = "217-2735",
                    Name = "3/8\" Hex Bearing",
                    Quantity = 2,
                    Type = "Bearing",
                    Link = "https://wcproducts.com/collections/cnc-hardware/products/ball-bearings",
                    Flange = true,
                    BoreType = "Hex",
                    Vendor = "WestCoast Products",
                    OuterDiameter = 1.125,
                    InnerDiameter = 0.375,
                    Width = 0.313,
                },
                new Bearing
                {
                    Sku = "WCP-0781",
                    Name = "1/2\" Round Bearing",
                    Quantity = 56,
                    Type = "Bearing",
                    Link = "https://wcproducts.com/collections/cnc-hardware/products/ball-bearings",
                    Flange = true,
                    BoreType = "Hex",
                    Vendor = "WestCoast Products",
                    OuterDiameter = 1.125,
                    InnerDiameter = 0.5,
                    Width = 0.313,
                },
                new Bearing
                {
                    Sku = "WCP-0780",
                    Name = "3/8\" Round Bearing",
                    Quantity = 0,
                    Type = "Bearing",
                    Link = "https://wcproducts.com/collections/cnc-hardware/products/ball-bearings",
                    Flange = true,
                    BoreType = "Hex",
                    Vendor = "WestCoast Products",
                    OuterDiameter = 1.125,
                    InnerDiameter = 0.375,
                    Width = 0.313,
                },
                new CustomItem
                {
                    Sku = "WCP-0680",
                    Name = "14t Aluminum Spur Gear",
                    Type = "Gear",
                    Custom = true,
                }
            };

            await context.Items.AddRangeAsync(items);
            await context.SaveChangesAsync();

        }        
    }
}