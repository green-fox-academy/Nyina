using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CarLicences.Models;
using CarLicences.Entities;

namespace CarLicences.Repositories
{
    public class LicencePlatesRepository
    {
        private LicencePlatesContext licencePlatesContext;

        public LicencePlatesRepository(LicencePlatesContext licencePlatesContext)
        {
            this.licencePlatesContext = licencePlatesContext;
        }

        public List<LicencePlatesModel> GetAllItems()
        {
            return licencePlatesContext.licencePlates.ToList();
        }

        public List<LicencePlatesModel> GetSearchedItem(string searchedItem)
        {
            return GetAllItems().Where(x => x.Plate.Contains(searchedItem)).ToList();
        }

        public List<LicencePlatesModel> GetPolice()
        {
            return GetAllItems().Where(x => x.Plate.StartsWith("RB")).ToList();
        }

        public List<LicencePlatesModel> GetDiplomats()
        {
            return GetAllItems().Where(x => x.Plate.StartsWith("DT")).ToList();
        }

        public List<LicencePlatesModel> GetFilteredItems(SearchModel searchModel)
        {
            if (searchModel.SearchedItem != null)
            {
                return GetSearchedItem(searchModel.SearchedItem);
            }
            else if (searchModel.Police == 1)
            {
                return GetPolice();
            }
            else if (searchModel.Diplomat == 1)
            {
                return GetDiplomats();
            }
            return GetAllItems();
        }

        public List<LicencePlatesModel> GetBrand(string brand)
        {
            return licencePlatesContext.licencePlates.Where(x => x.CarBrand.Equals(brand)).ToList();
        }
    }
}
