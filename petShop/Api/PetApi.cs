using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace petShop.Api
{
    public class PetApi
    {
        private string URI= @"https://petstore3.swagger.io/api/v3/";
        public HttpClient restClient = new HttpClient();

        public Task<Model.Pet> GetPetById(long? petId)
        {
            var pet =  GetPetByIdAsync(petId);
            return pet;
        }

        public async Task<Model.Pet> GetPetByIdAsync(long? petId)
        {
            var response = await restClient.GetAsync(URI + String.Format(@"pet/{0}", petId));
            var pet = JsonConvert.DeserializeObject<Model.Pet>(await response.Content.ReadAsStringAsync());
            return pet;
        }

        public async Task<Model.Pet> PostNewPet(petShop.Model.Pet newPet)
        {
            var json = JsonConvert.SerializeObject(newPet);

            var data = new StringContent(json, Encoding.UTF8, "application/json");
            restClient.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "*/*");
            restClient.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type","application/json");


            var response = await restClient.PostAsync(URI + "pet", data);
            var responseContent = await response.Content.ReadAsStringAsync();
            Console.WriteLine("I was here ");
           
            var pet = JsonConvert.DeserializeObject<Model.Pet>(await response.Content.ReadAsStringAsync());
            return pet;
        }

        //internal Task<Model.Pet> PostNewPet(Model.Pet newPet)
        //{
        //    throw new NotImplementedException();
        //}

        public void DeletePet(long? petId, string apiKey = null)
        {
            throw new NotImplementedException();
        }

        public List<PetApi> FindPetsByStatus(string status = null)
        {
            throw new NotImplementedException();
        }

        public List<PetApi> FindPetsByTags(List<string> tags = null)
        {
            throw new NotImplementedException();
        }
    }
}
