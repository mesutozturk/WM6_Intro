using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;

namespace XmlJsonServislerineBaglanma
{
    public class FourFactory
    {
        public const string clientID = "SB1OLYEJEIF5E3AMDBAX5TKTOOXXWDHGEKQGHJMFBCZXMIZL";
        public const string clientSecret = "QKKPKK5MQW1RVHAGFCXHQIK4UOM5ZAOW3BEH4R1UMBX5OBGJ";
        public const string apiUrl = "https://api.foursquare.com/v2/venues/search?";
        public string categoryCode = "4f04af1f2fb6e1c99f3db0bb";
        public int radius = 2000;
        public string latitude = "41.0446062";
        public string longitude = "29.0063537";

        string queryUrl = string.Empty;
        public string jsonString = string.Empty;

        public FourFactory()
        {
            queryUrl = apiUrl;
            queryUrl += "client_id=" + clientID;
            queryUrl += "&client_secret=" + clientSecret;
            queryUrl += "&v=" + $"{DateTime.Now:yyyyMMdd}";
            queryUrl += $"&ll={latitude},{longitude}";
            queryUrl += "&radius=" + radius;
            queryUrl += "&categoryId=" + categoryCode;
            GetVenues(queryUrl);
        }

        private async void GetVenues(string query)
        {
            HttpClient client = new HttpClient();
            try
            {
                jsonString = await client.GetStringAsync(query);
                //jsonString = client.GetStringAsync(query).Result;


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Four.Venue> Firmalar
        {
            get => FirmalariDoldur();
        }
        private List<Four.Venue> FirmalariDoldur()
        {
            Four sonuc = JsonConvert.DeserializeObject<Four>(jsonString);
            return sonuc.response.venues.ToList();
        }
    }
}
