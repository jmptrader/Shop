using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShopAPI.Models
{
    public enum ProductStatus
	{
	    OnStore,
        Waiting,
        NotWaiting
	}
    public class Product
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string PhotoURL { get; set; }
        public int Price { get; set; }
        public ProductStatus Status { get; set; }
        public virtual List<ProductType> ProductTypes { get; set; }
        public int ProductId { get; set; }
    }
}
