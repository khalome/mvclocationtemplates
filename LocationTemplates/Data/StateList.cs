using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LandInc.DAL
{
    public class StateList
    {
        List<State> states = new List<State>();

        public class State
        {
            public string Abbreviation { get; set; }
            public string Name { get; set; }
        }

        public StateList()
        {
            CreateStates();
        }

        public List<State> GetStates()
        {
            return states;
        }

        private void CreateStates()
        {
            states = new List<State>(50);
            states.Add(new State { Abbreviation = "AL", Name = "Alabama" });
            states.Add(new State{ Abbreviation = "AK", Name = "Alaska" });
            states.Add(new State{ Abbreviation = "AZ", Name = "Arizona" });
            states.Add(new State{ Abbreviation = "AR", Name = "Arkansas" });
            states.Add(new State{ Abbreviation = "CA", Name = "California" });
            states.Add(new State{ Abbreviation = "CO", Name = "Colorado" });
            states.Add(new State{ Abbreviation = "CT", Name = "Connecticut" });
            states.Add(new State{ Abbreviation = "DE", Name = "Delaware" });
            states.Add(new State{ Abbreviation = "DC", Name = "District Of Columbia" });
            states.Add(new State{ Abbreviation = "FL", Name = "Florida" });
            states.Add(new State{ Abbreviation = "GA", Name = "Georgia" });
            states.Add(new State{ Abbreviation = "HI", Name = "Hawaii" });
            states.Add(new State{ Abbreviation = "ID", Name = "Idaho" });
            states.Add(new State{ Abbreviation = "IL", Name = "Illinois" });
            states.Add(new State{ Abbreviation = "IN", Name = "Indiana" });
            states.Add(new State{ Abbreviation = "IA", Name = "Iowa" });
            states.Add(new State{ Abbreviation = "KS", Name = "Kansas" });
            states.Add(new State{ Abbreviation = "KY", Name = "Kentucky" });
            states.Add(new State{ Abbreviation = "LA", Name = "Louisiana" });
            states.Add(new State{ Abbreviation = "ME", Name = "Maine" });
            states.Add(new State{ Abbreviation = "MD", Name = "Maryland" });
            states.Add(new State{ Abbreviation = "MA", Name = "Massachusetts" });
            states.Add(new State{ Abbreviation = "MI", Name = "Michigan" });
            states.Add(new State{ Abbreviation = "MN", Name = "Minnesota" });
            states.Add(new State{ Abbreviation = "MS", Name = "Mississippi" });
            states.Add(new State{ Abbreviation = "MO", Name = "Missouri" });
            states.Add(new State{ Abbreviation = "MT", Name = "Montana" });
            states.Add(new State{ Abbreviation = "NE", Name = "Nebraska" });
            states.Add(new State{ Abbreviation = "NV", Name = "Nevada" });
            states.Add(new State{ Abbreviation = "NH", Name = "New Hampshire" });
            states.Add(new State{ Abbreviation = "NJ", Name = "New Jersey" });
            states.Add(new State{ Abbreviation = "NM", Name = "New Mexico" });
            states.Add(new State{ Abbreviation = "NY", Name = "New York" });
            states.Add(new State{ Abbreviation = "NC", Name = "North Carolina" });
            states.Add(new State{ Abbreviation = "ND", Name = "North Dakota" });
            states.Add(new State{ Abbreviation = "OH", Name = "Ohio" });
            states.Add(new State{ Abbreviation = "OK", Name = "Oklahoma" });
            states.Add(new State{ Abbreviation = "OR", Name = "Oregon" });
            states.Add(new State{ Abbreviation = "PA", Name = "Pennsylvania" });
            states.Add(new State{ Abbreviation = "RI", Name = "Rhode Island" });
            states.Add(new State{ Abbreviation = "SC", Name = "South Carolina" });
            states.Add(new State{ Abbreviation = "SD", Name = "South Dakota" });
            states.Add(new State{ Abbreviation = "TN", Name = "Tennessee" });
            states.Add(new State{ Abbreviation = "TX", Name = "Texas" });
            states.Add(new State{ Abbreviation = "UT", Name = "Utah" });
            states.Add(new State{ Abbreviation = "VT", Name = "Vermont" });
            states.Add(new State{ Abbreviation = "VA", Name = "Virginia" });
            states.Add(new State{ Abbreviation = "WA", Name = "Washington" });
            states.Add(new State{ Abbreviation = "WV", Name = "West Virginia" });
            states.Add(new State{ Abbreviation = "WI", Name = "Wisconsin" });
            states.Add(new State{ Abbreviation = "WY", Name = "Wyoming" });
        }
    }
}