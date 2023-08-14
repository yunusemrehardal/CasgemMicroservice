using CasgemMicroservice.Services.Order.Core.Application.Features.CQRS.Commands;
using CasgemMicroservice.Services.Order.Core.Application.Features.CQRS.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CasgemMicroservice.Services.Order.Presentation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrderDetailController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> OrderDetailList()
        {
            var values = await _mediator.Send(new GetAllOrderDetailQueryRequest());
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> OrderDetailGetById(int id)
        {
            var value = await _mediator.Send(new GetByIdOrderDetailQueryRequest(id));
            return Ok(value);

        }
        [HttpPost]
        public async Task<IActionResult> OrderDetailCreate(CreateOrderDetailCommandRequest createOrderDetailCommandRequest)
        {
            await _mediator.Send(createOrderDetailCommandRequest);
            return Ok("Sipariş Eklendi");
        }
        [HttpPut]
        public async Task<IActionResult> OrderDetailUpdate(UpdateOrderDetailCommandRequest updateOrderDetailCommandRequest)
        {
            await _mediator.Send(updateOrderDetailCommandRequest);
            return Ok("Sipariş Güncellendi");
        }
        [HttpDelete]
        public async Task<IActionResult> OrderDetailDelete(int id)
        {
            await _mediator.Send(new RemoveOrderDetailCommandRequest(id));
            return Ok("Sipariş Silindi");
        }
    }
}
