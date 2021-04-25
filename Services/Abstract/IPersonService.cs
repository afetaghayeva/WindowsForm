using System.Collections.Generic;
using System.Threading.Tasks;
using WindowsForm.Entities.Concrete;

namespace WindowsForm.Services.Abstract
{
    public interface IPersonService
    { 
        Task<List<PersonResponse>> GetPersonsAsync();
        Task<PersonResponse> SavePersonsAsync(PersonRequest person);
        Task<PersonResponse> UpdatePersonsAsync(PersonRequest person, int personId);
    }
}
