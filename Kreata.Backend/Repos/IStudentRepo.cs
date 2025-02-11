using Kreata.Backend.Repos.Base;
using Kreta.Shared.Enums;
using Kreta.Shared.Models;

namespace Kreata.Backend.Repos
{
    public interface IStudentRepo : IBaseRepo<Student>
    {
        public Task<Student> GetByNameAsync(string firstName, string lastName);
        public Task<List<Student>> GetStudentByClass(int schoolYear, SchoolClassType schoolClassType);

        public Task<int> GetNumberOfStudentAsync();

        public Task<int> GetNumberOfWomanAsync();
        public Task<int> GetNumberOfMaleAsync();

        public Task<int> GetNumberOfStudentsBornIn2021Async();
        public Task<int> GetNumberOfStudentsBornInAprilAsync();
        Task<int> GetNumberOfStudentByYearAsync(int year);
        Task<int?> GetNumberOfStudentByYearAndMonthAsync(int year, int month);
    }
}
