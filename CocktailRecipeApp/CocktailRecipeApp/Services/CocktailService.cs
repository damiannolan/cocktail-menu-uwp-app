using CocktailRecipeApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Formatting;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace CocktailRecipeApp.Services
{

    public interface ICocktailService
    {
        Task<CocktailList> SearchCocktails(string searchName);

        Task<CocktailList> RandomCocktail();
    }

    public class CocktailService : ICocktailService
    {
        private const string apiKey = "1";
        private const string searchEndpoint = "http://www.thecocktaildb.com/api/json/v1/" + apiKey + "/search.php?s=";
        private const string randomEndpoint = "http://www.thecocktaildb.com/api/json/v1/1/random.php";
        private HttpClient client;

        /*
        * Use the constructor to instantiate a new HttpClient
        * Set the headers up for accepting the Content-Type - application/json
        */
        public CocktailService()
        {
            this.client = new HttpClient();
            this.client.DefaultRequestHeaders.Accept.Clear();
            this.client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        /*
         * Implementation of method defined by ICocktailService interface
         * Append the string - searchName to the searchEndpoint
         * Set the HttpClient's baseAddress
         * Await the response
         * Handle response
         */
        public async Task<CocktailList> SearchCocktails(string searchName)
        {
            // Tried to implement using the HttpUtility - UrlEncode but was having problems getting it working
            // https://msdn.microsoft.com/en-us/library/zttxte6w.aspx
            // Had to use oldschool - replace() for dealing with search strings using spaces
            searchName = searchName.Replace(" ", "+");   
            client.BaseAddress = new Uri(searchEndpoint + searchName);

            HttpResponseMessage response = await client.GetAsync(client.BaseAddress);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<CocktailList>();

                // Manual Deserialisation
                // var jsonStr = await response.Content.ReadAsStringAsync();                
                // var jsonSettings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };
                // var manualDeserialisation = JsonConvert.DeserializeObject<CocktailList>(jsonStr);
                // return manualDeserialisation;
            }
            else
            {
                return null;
            }        
        }

        /*
         * Implementation of method defined by ICocktailService interface
         * Set the HttpClient's baseAddress
         * Await the response
         * Handle response
         */
        public async Task<CocktailList> RandomCocktail()
        {
            client.BaseAddress = new Uri(randomEndpoint);

            HttpResponseMessage response = await client.GetAsync(client.BaseAddress);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<CocktailList>();
            }
            else
            {
                return null;
            }
        }
    }
}
