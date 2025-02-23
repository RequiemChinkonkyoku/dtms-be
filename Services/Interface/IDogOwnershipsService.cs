using Models.DTOs.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface IDogOwnershipsService
    {
        Task<List<DogOwnershipResponse>> GetAllDogOwnerships();
        
    }
}
