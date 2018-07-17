namespace ApiConnector
{
    public class PlaceQuantitySearcher
    {
        RequestSender _requestSender = new RequestSender();
        public void FillPlaceQuantities(string placeName, AbstractRatingCategory ratingCategory)
        {
            Place placeToAnalize = _requestSender.GetLocalisationByName(placeName);

            for(int i = 0; i < ratingCategory.ListOfPlaceTypes.Count; i++)
            {
                ListOfResults listOfResults =  _requestSender.FindNear(placeToAnalize, ratingCategory.ListOfPlaceTypes[i].Name);
                ratingCategory.ListOfPlaceTypes[i].Quantity = listOfResults.results.Length;
                //////////////////
                System.Console.WriteLine(ratingCategory.ListOfPlaceTypes[i].Name + ": "+ ratingCategory.ListOfPlaceTypes[i].Quantity);
                //////////////////
            }
        }
    }
}
