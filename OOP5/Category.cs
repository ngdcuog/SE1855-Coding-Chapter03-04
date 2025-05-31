﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5
{
    public  class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Dictionary<int, Product> Products { get; set; }

        public Category() { 
            Products = new Dictionary<int, Product>();
        }

        /* Mọi dữ liệu ta cần làm đủ CRUD 
         * 
         */

        public void AddProduct(Product p)
        {
            if (Products.ContainsKey(p.Id))
            {
                return; // vì mã đã tồn tại 
            }
            Products.Add(p.Id, p);
        }

        // Xem toàn bộ Product ở danh muc 
        public void PrintAllProduct() { 
            foreach (KeyValuePair<int, Product> item in Products)
            {
                Product p = item.Value;
                Console.WriteLine(p);
            }
        }

        // lọc ra các sản phẩm có giá từ x tới y 
        public Dictionary<int, Product>FilterProductsByPrice(double min, double max)
        {
            Dictionary<int, Product> results = new Dictionary<int, Product>();
            results = Products.Where(item => item.Value.Price >= min && item.Value.Price <= max)
                .ToDictionary<int, Product>();

            return results;
        }

        // Sắp xếp sản phẩm theo đơn giá tăng dần 
        public Dictionary<int, Product> SortProductByPrice()
        {
            return Products.OrderBy(item => item.Value.Price)
                .ToDictionary<int, Product>();
        }

        // Sắp xếp sản phẩm theo giá tưang dần 
        // nếu đơn giá trùng nhau thì sắp xếp số lượng giảm dần 
        public Dictionary<int , Product> SortProductByPriceAscThenQuantityDesc()
        {
            return Products.OrderByDescending(item => item.Value.Quantity).OrderBy(item => item.Value.Price)
                .ToDictionary<int, Product>();
        }

        public bool UpdateProduct(Product p)
        {
            if(p == null) { return false; }
            if(Products.ContainsKey(p.Id) == false) { return false; }

            Products[p.Id] = p; // đè dữ liệu lên ô nhớ hiện tại 
                                // hoặc tham chiếu tới ô nhớ khác 
            return true;
        }

        public bool DeleteProduct(int id)
        {
            if(Products.ContainsKey(id) == false) {return false; }
            return Products.Remove(id);
        }
    }
}
