using System;
using System.Collections.Generic;
using System.Text;

namespace ApiConnector
{
    public abstract class AbstractRatingCategory
    {
        public int Distance { get; set; }
        public List<PlaceType> ListOfPlaceTypes { get; private set; } = new List<PlaceType>();
        public decimal Rating()
        {
            decimal rating = 0;
            foreach(PlaceType place in ListOfPlaceTypes)
            {
                rating += place.Quantity;
            }
            return rating;            
        }

        public void AddPlaceType(PlaceType place)
        {
            ListOfPlaceTypes.Add(place);
        }
    }

    public class PlaceType
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string Adress { get; set; }
        public PlaceType(string name)
        {
            Name = name;
        }
    }

}
