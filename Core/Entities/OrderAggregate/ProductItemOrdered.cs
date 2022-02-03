using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities.OrderAggregate
{
    public class ProductItemOrdered
    {
        public ProductItemOrdered(int productItemId, string product, string pictureUrl)
        {
            ProductItemId = productItemId;
            Product = product;
            PictureUrl = pictureUrl;
        }

        public int ProductItemId { get; set; }

        public string Product { get; set; }

        public string PictureUrl { get; set; }
    }
}