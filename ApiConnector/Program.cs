using System;

namespace ApiConnector
{
    class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

        static void Run()
        {
            LivingRatingCategory livingRatingCategory = new LivingRatingCategory();
            TouristicRatingCategory touristicRatingCategory = new TouristicRatingCategory();

            Console.WriteLine(livingRatingCategory.Rating());

            PlaceQuantitySearcher searcher = new PlaceQuantitySearcher();
            Console.WriteLine("Gdzie szukasz miejsca do życia?");
            searcher.FillPlaceQuantities(Console.ReadLine(), ChooseCategory());

            Console.WriteLine(livingRatingCategory.Rating());

            Console.Read();
        }

        static AbstractRatingCategory ChooseCategory()
        {
            LivingRatingCategory livingRatingCategory = new LivingRatingCategory();
            TouristicRatingCategory touristicRatingCategory = new TouristicRatingCategory();

            Console.WriteLine("Chcesz tam mieszkać (live) czy tylko zwiedzić? (travel)");
            string choice = Console.ReadLine();

            if(choice == "live")
            {
                return livingRatingCategory;
            }
            else if(choice == "travel")
            {
                return touristicRatingCategory;
            }
            else
            {
                return null;
            }
        }
    }
}
