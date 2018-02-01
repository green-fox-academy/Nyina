using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PracticeLicences.Entities;
using PracticeLicences.Models;

namespace PracticeLicences.Repositories
{
    public class LicencesRepository
    {
        private LicencesContext licencesContext;

        public LicencesRepository(LicencesContext licencesContext)
        {
            this.licencesContext = licencesContext;
        }

        public List<LicencesModel> GetAllItems()
        {
            return licencesContext.TrialLicencePlates.ToList();
        }

        public List<LicencesModel> GetAnItem(string searchedItem)
        {
            return GetAllItems().Where(x => x.Plate.Contains(searchedItem)).ToList();
        }

        public List<LicencesModel> GetSearchedItems(Search search)
        {
            if (search.Q != null)
            {
                return GetAnItem(search.Q);
            }
            else if (search.Police == 1)
            {
                return GetAllItems().Where(x => x.Plate.StartsWith("RB")).ToList();
            }
            else if (search.Diplomat ==1)
            {
                return GetAllItems().Where(x => x.Plate.StartsWith("DT")).ToList();
            }
            return GetAllItems();
        }

        public List<LicencesModel> GetBrand(string brand)
        {
            return GetAllItems().Where(x => x.CarBrand.Equals(brand)).ToList();
        }
    }
}
