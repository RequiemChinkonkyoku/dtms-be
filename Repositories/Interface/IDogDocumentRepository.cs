using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interface
{
    public interface IDogDocumentRepository : IRepositoryBase<DogDocument>
    {
        Task<DogDocument> GetDocumentById(string id);

        Task<List<DogDocument>> GetAllDocument();

        Task<List<DogDocument>> GetDocumentsByDogId(string dogId);
    }
}
