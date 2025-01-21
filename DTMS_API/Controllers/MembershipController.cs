using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.DTOs.Membership;
using Services.Implement;
using Services.Interface;

namespace DTMS_API.Controllers
{
    [Route("api/membership")]
    [ApiController]
    public class MembershipController : ControllerBase
    {
        private readonly IMembershipService _membershipService;

        public MembershipController(IMembershipService membershipService)
        {
            _membershipService = membershipService;
        }

        [HttpGet("get-all-memberships")]
        public async Task<IActionResult> GetAllMemberships()
        {
            var response = await _membershipService.GetAllMemberships();
            return Ok(response);
        }

        [HttpGet("get-membership-by-id/{id}")]
        public async Task<IActionResult> GetMembershipById(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                return BadRequest("Id is required.");
            try
            {
                var membership = await _membershipService.GetMembershipById(id);
                if (membership == null)
                    return NotFound("Membership not found.");
                return Ok(membership);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPost("create-membership")]
        public async Task<IActionResult> CreateMembership(CreateMembershipRequest request)
        {
            try
            {
                var response = await _membershipService.CreateMembershipAsync(request);
                return CreatedAtAction(nameof(GetMembershipById), new { id = response.Id }, response);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPut("update-membership/{id}")]
        public async Task<IActionResult> UpdateMembership(string id, [FromBody] CreateMembershipRequest request)
        {
            if (string.IsNullOrWhiteSpace(id))
                return BadRequest("Invalid id.");

            try
            {
                var response = await _membershipService.UpdateMembershipAsync(id, request);
                return Ok(response);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpDelete("delete-membership/{id}")]
        public async Task<IActionResult> DeleteMembership(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                return BadRequest("Invalid id.");

            try
            {
                var success = await _membershipService.DeleteMembershipAsync(id);
                if (!success)
                    return NotFound();
                return NoContent();
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
