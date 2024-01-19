using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RandBox.Server.Repositories.Contracts;
using RandBox.Shared.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RandBox.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public StaffController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Staff>>> GetAllStaff()
        {
            var staffList = await _unitOfWork.StaffRepository.GetAll();

            if (staffList == null)
            {
                return NotFound();
            }

            return Ok(staffList);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<IEnumerable<Staff>>> GetStaff(int id)
        {
            var staff = await _unitOfWork.StaffRepository.GetById(id);

            if (staff == null)
            {
                return NotFound();
            }

            return Ok(staff);
        }

        [HttpPost]
        public async Task<ActionResult> AddStaff(Staff staff)
        {
            await _unitOfWork.StaffRepository.Insert(staff);
            await _unitOfWork.Save();

            return CreatedAtAction(nameof(GetStaff), new { id = staff.StaffID }, staff);
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> UpdateStaff(int id, Staff newStaff)
        {
            if (id != newStaff.StaffID)
            {
                return BadRequest();
            }

            _unitOfWork.StaffRepository.Update(newStaff);

            try
            {
                await _unitOfWork.Save();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await StaffExists(id))
                {
                    return NotFound();
                }
            }
            return Ok(newStaff);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteStaffById(int id)
        {
            await _unitOfWork.StaffRepository.DeleteById(id);
            await _unitOfWork.Save();

            return NoContent();
        }

        protected async Task<bool> StaffExists(int id)
        {
            return await _unitOfWork.StaffRepository.GetById(id) != null;
        }
    }
}
