using CasgemMicroservice.Services.Cargo.BusinessLayer.Abstract;
using CasgemMicroservice.Services.Cargo.EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CasgemMicroservice.Services.Cargo.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CargoStatesController : ControllerBase
    {
        private readonly ICargoStateService _cargoStateService;

        public CargoStatesController(ICargoStateService cargoStateService)
        {
            _cargoStateService = cargoStateService;
        }

        [HttpGet]
        public IActionResult CargoStateList()
        {
            var values = _cargoStateService.GetAll();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult CargoStateGet(int id)
        {
            var value = _cargoStateService.GetById(id);
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CargoStateCreate(CargoState cargoState1)
        {
            _cargoStateService.Insert(cargoState1);
            return Ok("Kargo Durumu Eklendi.");
        }

        [HttpPut]
        public IActionResult CargoStateUpdate(CargoState cargoState1)
        {
            _cargoStateService.Update(cargoState1);
            return Ok("Kargo Durumu Güncellendi.");
        }

        [HttpDelete]
        public IActionResult CargoStateDelete(CargoState cargoState1)
        {
            _cargoStateService.Delete(cargoState1);
            return Ok("Kargo durumu Silindi");
        }
    }
}
