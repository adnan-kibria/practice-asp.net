using BLL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentService _deptService;
        public DepartmentController(DepartmentService deptService)
        {
            _deptService = deptService;
        }

        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var data = await _deptService.GetAll();
            return Ok(data);
        }

        [HttpGet("get/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var data = await _deptService.Get(id);
            return Ok(data);
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add(DepartmentDTO dept)
        {
            var data = await _deptService.Add(dept);
            return Ok(data);
        }
    }
}
