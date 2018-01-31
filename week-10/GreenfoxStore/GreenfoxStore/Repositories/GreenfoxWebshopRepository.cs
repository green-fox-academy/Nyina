using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GreenfoxStore.Entities;
using GreenfoxStore.Models;
using Microsoft.EntityFrameworkCore;
using GreenfoxStore.Viewmodels;

namespace GreenfoxStore.Repositories
{
    public class GreenfoxWebshopRepository
    {
        private GreenfoxWebshopContext greenfoxWebshopContext;

        public GreenfoxWebshopRepository (GreenfoxWebshopContext greenfoxWebshopContext)
        {
            this.greenfoxWebshopContext = greenfoxWebshopContext;
        }

        //public GreenfoxWebshop GetAListElement(string searchedString)
        //{
        //    //return toDoContext.ToDos.Include(x => x.User).Where(t => t.Title.Contains(searchedString)).ToList();
        //    return greenfoxWebshopContext.GreenfoxWebshops
        //        .FirstOrDefault(t => (t.ItemName.Contains(searchedString)));
        //}

        public List<GreenfoxWebshop> AllClothes()
        {
            return greenfoxWebshopContext.GreenfoxWebshops.ToList();
        }

        public List<string> GetItemNames()
        {
            return AllClothes().Select(x => x.ItemName).Distinct().OrderBy(x => x).ToList();
        }

        public List<string> GetSizes()
        {
            return AllClothes().Select(x => x.Size).Distinct().OrderBy(x => x).ToList();
        }

        public GreenfoxWebshop GetAProductWithSize(string productName, string size)
        {
            return greenfoxWebshopContext.GreenfoxWebshops.FirstOrDefault(x => x.ItemName.Equals(productName) && x.Size.Equals(size));
        }

        public GreenfoxWebshopViewmodel CreateViewModel()
        {
            GreenfoxWebshopViewmodel greenfoxWebshopViewmodel = new GreenfoxWebshopViewmodel
            {
                Sizes = GetSizes(),
                ItemNames = GetItemNames(),
                GreenfoxTable = AllClothes()
            };
            return greenfoxWebshopViewmodel;
        }

        public Summary GetSummary(string productName, string size, int amount)
        {
            var filteredProduct = GetAProductWithSize(productName, size);
            Summary sumProduct = new Summary
            {
                ItemName = filteredProduct.ItemName,
                Manufacturer = filteredProduct.Manufacturer,
                Category = filteredProduct.Category,
                Size = filteredProduct.Size,
                Quantity = amount,
                TotalPrice = filteredProduct.UnitPrice * amount
            };
            return sumProduct;
        }

        public List<GreenfoxWebshop> GetItemsFromQuery(double price, string type)
        {
            List<GreenfoxWebshop> filteredItems = new List<GreenfoxWebshop>();

            if (type.Equals("equal"))
            {
                filteredItems = greenfoxWebshopContext.GreenfoxWebshops.Where(x => x.UnitPrice == price).ToList();
            }
            else if (type.Equals("lower"))
            {
                filteredItems = greenfoxWebshopContext.GreenfoxWebshops.Where(x => x.UnitPrice < price).ToList();
            }
            else if (type.Equals("higher"))
            {
                filteredItems = greenfoxWebshopContext.GreenfoxWebshops.Where(x => x.UnitPrice > price).ToList();
            }
            return filteredItems;
        }
    }
}
