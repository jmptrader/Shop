using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ShopAPI.Models
{
    public class ShopContextInitializer: DropCreateDatabaseAlways<ShopContext>
    {
        protected override void Seed(ShopContext context)
        {
            var productTypes = new List<ProductType>();
            productTypes.Add(new ProductType() { TypeName = "Clocks" });
            context.Products.Add(new Product()
            {
                Description = "First product",
                Price = 200,
                Status = ProductStatus.OnStore,
                ProductTypes = productTypes
            });
        }
    }
}