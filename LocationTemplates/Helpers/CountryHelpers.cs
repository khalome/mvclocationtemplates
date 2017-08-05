using LandInc.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LocationTemplates.Helpers
{
    public class CountryHelpers
    {
        public static IEnumerable<SelectListItem> GetCountries(string selectedValue)
        {
            var countries = new CountryArray();
            var list = countries.countries
                .ToList()
                .Select(m => new SelectListItem
                {
                    Value = m.Alpha3Code.ToString(),
                    Text = m.Name.ToString(),
                    Selected = (m.Alpha3Code == selectedValue)
                });

            return list;
        }
    }
}