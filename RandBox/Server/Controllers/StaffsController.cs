    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using RandBox.Server.Repositories.Contracts;
    using RandBox.Shared.Domain;

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

            // get all staff
            [HttpGet]
            public async Task<ActionResult<IEnumerable<Staff>>> GetAllStaff()

            {
                var staff = await _unitOfWork.StaffRepository.GetAll();
                if (staff == null)
                {
                    return NotFound();
                }

                return Ok(staff);

            }


            //get staff by id
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

            // put staff
            [HttpPut("{id}")]
            public async Task<IActionResult> PutStaff(int id, Staff staff)
            {
                if (id != staff.StaffID)
                {
                    return BadRequest();
                }

                _unitOfWork.StaffRepository.Update(staff);

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
                    else
                    {
                        throw;
                    }
                }

                return NoContent();
            }




        // post staff
        [HttpPost]
        public async Task<ActionResult<Staff>> PostStaff(Staff staff)
        {
            await _unitOfWork.StaffRepository.Insert(staff);
            await _unitOfWork.Save();
            return CreatedAtAction("GetMake", new { id = staff.StaffID }, staff);
        }

        //delete staff by id
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStaff(int id)
        {
            var staff = await _unitOfWork.StaffRepository.GetById(id);

            if (staff == null)
            {
                return NotFound();
            }
            await _unitOfWork.StaffRepository.DeleteById(id);
            await _unitOfWork.Save();
            return NoContent();
        }

        //checks if (entity) already exists in (entity)repo in this case staff
        private async Task<bool> StaffExists(int id)
        {
            var staff = await _unitOfWork.StaffRepository.GetById(id);
            return staff != null;
        }
    }
}

 