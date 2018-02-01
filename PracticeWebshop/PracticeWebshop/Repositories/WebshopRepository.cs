using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PracticeWebshop.Entities;
using PracticeWebshop.Models;
using PracticeWebshop.Viewmodels;

namespace PracticeWebshop.Repositories
{
    public class WebshopRepository
    {
        private WebshopContext webshopContext;

        public WebshopRepository(WebshopContext webshopContext)
        {
            this.webshopContext = webshopContext;
        }

        public List<WebshopModel> GetAllItems()
        {
            return webshopContext.PracticeWarehouse.ToList();
        }

        public List<string> GetSizeList()
        {
            return GetAllItems().Select(x => x.Size).Distinct().OrderBy(x => x).ToList();
        }

        public List<string> GetItemList()
        {
            return GetAllItems().Select(x => x.ItemName).Distinct().OrderBy(x => x).ToList();
        }

        public WebshopModel GetAProductBySize(string name, string size)
        {
            return webshopContext.PracticeWarehouse.FirstOrDefault(x => x.ItemName.Equals(name) && x.Size.Equals(size));
        }

        public Viewmodel CreateAViewmodel()
        {
            Viewmodel viewmodel = new Viewmodel()
            {
                Clotehs = GetAllItems(),
                Sizes = GetSizeList(),
                Items = GetItemList()
            };
            return viewmodel;
        }

        public Summary ShowSummary(string product, string size, int amount)
        {
            var filteredProduct = GetAProductBySize(product, size);
            Summary summary = new Summary
            {
                ItemName = filteredProduct.ItemName,
                Manufacturer = filteredProduct.Manufacturer,
                Category = filteredProduct.Category,
                Size = filteredProduct.Size,
                Amount = amount,
                TotalPrice = filteredProduct.UnitPrice * amount
            };
            return summary;
        }

        public List<WebshopModel> GetItemsFromQuery(double price, string type)
        {
            List<WebshopModel> filteredList = new List<WebshopModel>();

            if(type.Equals("equals"))
            {
                filteredList = webshopContext.PracticeWarehouse.Where(x => x.UnitPrice == price).ToList();
            }
            if (type.Equals("lower"))
            {
                filteredList = webshopContext.PracticeWarehouse.Where(x => x.UnitPrice < price).ToList();
            }
            if (type.Equals("higher"))
            {
                filteredList = webshopContext.PracticeWarehouse.Where(x => x.UnitPrice > price).ToList();
            }
            return filteredList;
        }
    }
}
