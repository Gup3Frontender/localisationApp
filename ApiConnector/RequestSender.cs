using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace ApiConnector
{
    public class RequestSender
    {
        /// <summary>
        /// API KEY
        /// AIzaSyCIxaqwOzo2dsq8cUsKlkgQcjRH4w1LRRY
        /// </summary>

        public Place GetLocalisationByName(string placeName)
        {
            string getLocalisationRequestString = 
                $"https://maps.googleapis.com/maps/api/place/findplacefromtext/json?input={placeName}&inputtype=textquery&fields=name,geometry&key=AIzaSyCIxaqwOzo2dsq8cUsKlkgQcjRH4w1LRRY";

            WebRequest Request = WebRequest.Create(getLocalisationRequestString);
            WebResponse response = Request.GetResponse();

            if (((HttpWebResponse)response).StatusDescription == "OK")
            {
                Stream dataStream = response.GetResponseStream();

                StreamReader reader = new StreamReader(dataStream);

                string responseFromServer = reader.ReadToEnd();

                reader.Close();
                response.Close();
                return JsonConvert.DeserializeObject<Place>(responseFromServer);
            }
            else
            {
                return null;
            }
        }

        public void FindNear(Place searchPlace, string type)
        {
            if (searchPlace != null)
            {

                string nearByRequestString = 
                    $"https://maps.googleapis.com/maps/api/place/nearbysearch/json?location={searchPlace.Coordinates}&radius=1700&type={type}&key=AIzaSyCIxaqwOzo2dsq8cUsKlkgQcjRH4w1LRRY";
                WebRequest Request = WebRequest.Create(nearByRequestString);
                WebResponse response = Request.GetResponse();
                Stream dataStream = response.GetResponseStream();

                StreamReader reader = new StreamReader(dataStream);

                string jsonResponse = reader.ReadToEnd();

                ListOfResults listOfResults = JsonConvert.DeserializeObject<ListOfResults>(jsonResponse);
            }
        }
    }

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

    public class ListOfResults
    {
        public Results[] results;
    }

    public class Results
    {
        public Geometry geometry;
        public string name;
        public string id;
        public string vicinity;
    }

    public class Candidates
    {
        public Geometry geometry;
        public string name;
    }

    public class Geometry
    {
        public Location location;
    }

    public class Location
    {
        public float lat;
        public float lng;
    }
}
