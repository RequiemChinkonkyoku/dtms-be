using Models.DTOs.DogCertificate.Response;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interface
{
    public interface IDogCertificateRepository : IRepositoryBase<DogCertificate>
    {
        Task<List<DogCertificate>> GetAllWithDetailsAsync();
        Task<DogCertificate> GetByIdWithDetailAsync(string id);
        Task<bool> AnyAsync(Expression<Func<DogCertificate, bool>> predicate);
        Task<DogCertificate> AddAsync(DogCertificate dogCertificate);
        Task<DogCertificate> GetDogCertificateByDogAndCert(string dogId, string certId);
    }
}
