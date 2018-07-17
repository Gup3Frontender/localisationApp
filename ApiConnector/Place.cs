namespace ApiConnector
{
    public class Place
    {
        public Candidates[] candidates;
        public string Name
        {
            get
            {
                 return candidates[0].name;
            }
        }
        public string Coordinates
        {
            get
            {
                string coordinates = string.Empty;
                coordinates += candidates[0].geometry.location.lat.ToString(System.Globalization.CultureInfo.InvariantCulture);
                coordinates += ", ";
                coordinates += candidates[0].geometry.location.lng.ToString(System.Globalization.CultureInfo.InvariantCulture);
                return coordinates;
            }
        }
    }
}
