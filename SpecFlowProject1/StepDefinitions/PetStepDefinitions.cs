using System;
using TechTalk.SpecFlow;
using petShop.Model;
using petShop.Api;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class PetStepDefinitions
    {
        private Pet _pet = new Pet();
        private Pet _myCat;
        private Category _category = new Category();
        private PetApi _petApi = new PetApi();
        [Given(@"the pet name is ""([^""]*)""")]
        public void GivenThePetNameIs(string petName)
        {
            _pet.Name = petName;
        }

        [Given(@"the pet category id is  (.*)")]
        public void GivenThePetCategoryIdIs(int p0)
        {
           _category.Id = p0;
        }

        [Given(@"the pet category name is  ""([^""]*)""")]
        public void GivenThePetCategoryNameIs(string categoryName)
        {
            _category.Name = categoryName;
        }


        [Given(@"the pet id is (.*)")]
        public void GivenThePetIdIs(int p0)
        {
            _pet.Id = p0;
        }

        [When(@"creating new pet")]
        public void WhenCreatingNewPet()
        {
            
            Task<Pet> jnk = _petApi.PostNewPet(_pet);
            jnk.Wait();
        }

        [When(@"getting pet with id (.*)")]
        public void WhenGettingPetWithId(int p0)
        {
            Task<Pet> jnk = _petApi.GetPetById(p0);
            jnk.Wait();
            _myCat = jnk.Result;
           
        }

        [Then(@"the pet id should be (.*)")]
        public void ThenThePetIdShouldBe(int p0)
        {
            _myCat.Id.Should().Be(p0);
        }

    }
}
