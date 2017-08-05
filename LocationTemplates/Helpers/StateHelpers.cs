using LandInc.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LocationTemplates.Helpers
{
    public class StatesHelper
    {
        public static IEnumerable<SelectListItem> GetStates(string selectedValue)
        {
            var states = new StateList();
            var list = states.GetStates()
                .ToList()
                .Select(m => new SelectListItem
                {
                    Value = m.Abbreviation.ToString(),
                    Text = m.Name.ToString(),
                    Selected = (m.Abbreviation == selectedValue)
                });

            return list;
        }
    }
}