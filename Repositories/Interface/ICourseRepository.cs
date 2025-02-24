using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interface
{
    public interface ICourseRepository : IRepositoryBase<Course>
    {
        public Task<Course> GetCourseById(string id);
        public Task<List<Course>> GetCoursesByCategoryId(string categoryId);
    }
}
