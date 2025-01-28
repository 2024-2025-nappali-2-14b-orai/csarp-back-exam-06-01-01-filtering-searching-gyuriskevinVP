using Kreata.Backend.Controllers.Base;
using Kreata.Backend.Repos;
using Kreta.Shared.Assemblers;
using Kreta.Shared.Dtos;
using Kreta.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kreata.Backend.Controllers
{
    public partial class StudentController : BaseController<Student, StudentDto>
    {
        private IStudentRepo _studentRepo;
        public StudentController(StudentAssembler? assambler, IStudentRepo? repo) : base(assambler, repo)
        {
            _studentRepo = repo ?? throw new ArgumentNullException(nameof(repo));
        }

        [HttpGet("getstudentbyfullname")]
        public async Task<IActionResult> GetStudentByFullName([FromQuery] FullNameQueryDto fullNameDto)
        {
            return Ok(await _studentRepo.GetByNameAsync(fullNameDto.FirstName, fullNameDto.LastName));
        }

        [HttpGet("NumberOfStudent")]
        public async Task<IActionResult> GetNumberOfStudentAsync()
        {
            return Ok(await _studentRepo.GetNumberOfStudentAsync());
        }

        [HttpGet("NumberOfWoman")]
        public async Task<IActionResult> GetNumberOfWomanAsync()
        {
            return Ok(await _studentRepo.GetNumberOfWomanAsync());
        }

        [HttpGet("NumberOfMale")]
        public async Task<IActionResult> GetNumberOfMaleAsync()
        {
            return Ok(await _studentRepo.GetNumberOfMaleAsync());
        }

        [HttpGet("NumberOfStudentsBornIn2021")]
        public async Task<IActionResult> GetNumberOfStudentsBornIn2021Async()
        {
            return Ok(await _studentRepo.GetNumberOfStudentsBornIn2021Async());
        }

        [HttpGet("NumberOfStudentsBornInApril")]
        public async Task<IActionResult> GetNumberOfStudentsBornInAprilAsync()
        {
            return Ok(await _studentRepo.GetNumberOfStudentsBornInAprilAsync());
        }
    }
}
