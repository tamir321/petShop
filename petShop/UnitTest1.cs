using Newtonsoft.Json;
using NUnit.Framework;
using petShop.Api;
using petShop.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace petShop
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public  void getLion()
        {
            PetApi petApi = new PetApi();
            Task<Model.Pet> jnk =  petApi.GetPetById(7);
            jnk.Wait();
            Pet myCat = jnk.Result;
            string name = myCat.Name;
            Assert.AreEqual("Lion 1",name);
        }

        [Test]
        public void createPet()
        {
            Category dog = new Category(1, "Dogs");
            Pet newPet = new Pet(id:2345345, name:"tamir",category:dog,photoUrls: new List<string> { "string1", "string2" } );
          
            PetApi petApi = new PetApi();
            Task<Model.Pet> jnk = petApi.PostNewPet(newPet);
            jnk.Wait();
            System.Console.WriteLine(jnk.ToString());

        }


       
    }
}