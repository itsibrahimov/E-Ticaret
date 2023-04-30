using System;
using System.Linq;
using System.Threading.Tasks;
using ShopApp.Entites;
using System.Collections.Generic;

namespace ShopApp.WebUI.Models
{public class PageInfo
    {
        public int TotalItem { get; set; }
        public int ItemPerPage { get; set; }
        public int CurrentPage { get; set; }
        public string CurrentCategory { get; set; }

        public int TotalPages()
        {
            return (int)Math.Ceiling((decimal)TotalItem / ItemPerPage);
        }
    }
    public class ProductListModel
    {
        public PageInfo PageInfo { get; set; }
        public List<Product> Products { get; set; }
    }
}
