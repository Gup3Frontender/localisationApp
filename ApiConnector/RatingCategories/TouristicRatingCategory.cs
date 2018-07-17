namespace ApiConnector
{
    public class TouristicRatingCategory : AbstractRatingCategory
    {
        public TouristicRatingCategory()
        {
            AddPlaceType(new PlaceType("train_station"));
            AddPlaceType(new PlaceType("embassy"));
            AddPlaceType(new PlaceType("art_gallery"));
            AddPlaceType(new PlaceType("restaurant"));
            AddPlaceType(new PlaceType("spa"));
            AddPlaceType(new PlaceType("park"));
            AddPlaceType(new PlaceType("pharmacy"));
            AddPlaceType(new PlaceType("travel_agency"));
            AddPlaceType(new PlaceType("museum"));            
        }
    }

}
