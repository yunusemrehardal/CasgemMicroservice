using CasgemMicroservice.Services.Discount.Dtos;
using CasgemMicroservice.Services.Discount.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CasgemMicroservice.Services.Discount.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountCouponsController : ControllerBase
    {
        private readonly IDiscountService _discountService;

        public DiscountCouponsController(IDiscountService discountService)
        {
            _discountService = discountService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllDiscountCoupons()
        {
            var values = await _discountService.GetAllDiscountCouponsAsync();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdDiscountCoupon(int id)
        {
            var value = await _discountService.GetByIdDiscountCouponAsync(id);
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateDiscountCouponsAsync(CreateDiscountDto createDiscountDto)
        {
            await _discountService.CreateDiscountCouponsAsync(createDiscountDto);
            return Ok("Kupon başarıyla oluşturuldu.");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateDiscountCouponsAsync(UpdateDiscountDto updateDiscountDto)
        {
            await _discountService.UpdateDiscountCouponsAsync(updateDiscountDto);
            return Ok("Kupon Başarıyla Güncellendi");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteDiscountCoupon(int id)
        {
            await _discountService.DeleteDiscountCouponsAsync(id);
            return Ok("Kupon başarıyla silindi.");
        }
    }
}
