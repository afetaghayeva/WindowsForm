using System.Collections.Generic;
using System.Threading.Tasks;
using WindowsForm.Entities.Concrete;
using WindowsForm.Helpers;
using WindowsForm.Services.Abstract;

namespace WindowsForm.Services.Concrete
{
    public class PersonService:IPersonService
    {
        private string baseUrl = "http://161.97.144.100:9990/ecare/api/person/";
        public async Task<List<PersonResponse>> GetPersonsAsync()
        {
            return await ServiceHelper.GetDataAsync<List<PersonResponse>>(this.baseUrl + "all");
        }

        public async Task<PersonResponse> SavePersonsAsync(PersonRequest person)
        {
            return await ServiceHelper.PostDataAsync<PersonResponse>(this.baseUrl + "save", person);
        }

        public async Task<PersonResponse> UpdatePersonsAsync(PersonRequest person, int personId)
        {
            return await ServiceHelper.UpdateDataAsync<PersonResponse>(this.baseUrl + "update/" + personId, person);
        }
    }
}
