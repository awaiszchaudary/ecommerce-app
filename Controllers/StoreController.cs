using System.Security.Claims;
using ecommerce_app.DTOs;
using ecommerce_app.Interfaces;
using ecommerce_app.Repositories;
using ecommerce_app.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ecommerce_app.Controllers
{
    [Authorize(Roles = "Admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class StoreController : ControllerBase
    {
        private readonly IStoreRepository _storeRepository;

        public StoreController(IStoreRepository storeRepository)
        {
            _storeRepository = storeRepository;
        }

        [HttpPost]
        public async Task<IActionResult> Add(StoreDTO storeDTO)
        {
            var userId = User.GetUserId();
            if (userId == null)
                return Unauthorized("User ID not found in token.");

            storeDTO.UserId = userId;

            var store = await _storeRepository.CreateAsync(storeDTO);
            return Ok(store);
        }
    }
}
