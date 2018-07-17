namespace ApiConnector
{
    public class LivingRatingCategory : AbstractRatingCategory
    {
        public LivingRatingCategory()
        {
            AddPlaceType(new PlaceType("bakery"));
            AddPlaceType(new PlaceType("church"));
            AddPlaceType(new PlaceType("doctor"));
            AddPlaceType(new PlaceType("gas_station"));
            AddPlaceType(new PlaceType("library"));
            AddPlaceType(new PlaceType("park"));
            AddPlaceType(new PlaceType("pharmacy"));
            AddPlaceType(new PlaceType("school"));
            AddPlaceType(new PlaceType("store"));
        }
                
    }

}
